using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PentaGol.Data.IRepositories;
using PentaGol.Domain.Confirgurations;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.Admin;
using PentaGol.Service.Exceptions;
using PentaGol.Service.Extensions;
using PentaGol.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Admin> repository;
        private readonly IMapper mapper;

        public AdminService(IRepository<Admin> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<AdminResultDto> AddAsync(AdminCreationDto dto)
        {
            var existingAdmin = await this.repository.SelectAsync(x => x.UserName == dto.UserName & x.IsDeleted == false);
            if (existingAdmin != null)
                throw new PentaGolException(409, "An admin with the same username already exists");

            var mapped = this.mapper.Map<Admin>(dto);
            mapped.CreatedOn = DateTime.UtcNow;
            await this.repository.InsertAsync(mapped);
            await this.repository.SaveAsync();

            return this.mapper.Map<AdminResultDto>(mapped);
        }

        public async ValueTask<AdminResultDto> ModifyAsync(long id, AdminCreationDto dto)
        {
            var admin = await this.repository.SelectAsync(x => x.Id == id && x.IsDeleted == false);
            if (admin is null)
                throw new PentaGolException(404, "Not Found");
            admin.UpdatedOn = DateTime.UtcNow;
            await this.repository.SaveAsync();
            return this.mapper.Map<AdminResultDto>(admin);
        }


        public async ValueTask<bool> RemoveAsync(long id)
        {
            var admin = await this.repository.SelectAsync(x => x.Id == id && x.IsDeleted == false);
            if (admin == null)
                throw new PentaGolException(404, "Admin not found");
            await this.repository.DeleteAsync(admin);
            await this.repository.SaveAsync();

            return true;
        }

        public async ValueTask<IEnumerable<AdminResultDto>> RetrieveAll(PaginationParams @params = null)
        {
            var admins = await this.repository.SelectAll(x => x.IsDeleted == false).ToPagedList(@params).ToListAsync();
            return this.mapper.Map<IEnumerable<AdminResultDto>>(admins);
        }

        public async ValueTask<AdminResultDto> RetrieveById(long id)
        {
            var admin = await this.repository.SelectAsync(x => x.Id == id && x.IsDeleted == false);
            if (admin == null)
                throw new PentaGolException(404, "Admin not found");

            return this.mapper.Map<AdminResultDto>(admin);
        }
        public async ValueTask<Admin> RetrieveByUsername(string username)
        {
            var admin = await this.repository.SelectAsync(x => x.UserName == username && x.IsDeleted == false);
            if (admin == null)
                throw new PentaGolException(404, "Admin not found");

            return admin;
        }
    }
}
