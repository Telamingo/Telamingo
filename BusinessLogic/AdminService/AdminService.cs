﻿using BusinessLogic.Identity.GenerateToken;
using Domain.AggregateModels.AdminAggregate;
using Domain.Dtos.AdminDtos;
using System.Threading.Tasks;

namespace BusinessLogic.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;
        private readonly IGenerateTokenService generateTokenService;

        public AdminService(IAdminRepository adminRepository,
            IGenerateTokenService generateTokenService)
        {
            this.adminRepository = adminRepository;
            this.generateTokenService = generateTokenService;
        }
        public async Task<string> AdminLogin(AdminDto model)
        {
            AdminDto admin = await adminRepository.GetAdminAsync(model);
            #region JWT
            string token = generateTokenService.AdminAuthentication(admin);
            #endregion

            return token;
        }
    }
}