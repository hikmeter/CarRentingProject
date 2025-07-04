﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingsWithCars();
        List<GetCarPricingsWithTimePeriodsQueryResult> GetCarPricingsWithTimePeriods();
    }
}
