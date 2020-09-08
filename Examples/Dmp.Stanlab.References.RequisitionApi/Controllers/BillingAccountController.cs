﻿using Dmp.Stanlab.References.RequisitionApi.Repositories;
using Dmp.Stanlab.References.RequisitionApi.Specifications;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dmp.Stanlab.References.RequisitionApi.Controllers
{
    [Authorize]
    public class BillingAccountController : BillingAccountControllerBase
    {
        private readonly ContractRepository _repository;

        public BillingAccountController(ContractRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public override Task<IEnumerable<BillingAccount>> GetBillingAccounts()
        {
            // The user's organization
            var vat = User.FindFirst(DmpClaimTypes.Company);

            var contracts = _repository.GetBillingAccounts();
            return Task.FromResult(contracts);
        }
    }
}