using Last_min_Tour.Models;
using System;
using TourUnit;
using Xunit;

namespace TourUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddButton()
        {
            TourBusiness TourTest = new();
            Tour test = new()
            {
                Direction = Direction.Turkey,
                Departure = DateTime.Now,
                NumberOfNights = 30,
                CostVacationer = 100,
                NumberOfVacationers = 2,
                WiFi = true,
                Surcharges = 450.32m,
            };
            TourTest.Add(test); 
            var result = TourTest.GetList();
            Assert.Equal(test, result[0]);
        }
        [Fact]
        public void EditButton()
        {
            TourBusiness TourTest = new();
            Tour test = new()
            {
                Direction = Direction.Turkey,
                Departure = DateTime.Now,
                NumberOfNights = 30,
                CostVacationer = 100,
                NumberOfVacationers = 2,
                WiFi = true,
                Surcharges = 450.32m,
            };
            TourTest.Add(test);
            Tour test2 = new()
            {
                Direction = Direction.Spain,
                Departure = DateTime.Now.AddDays(5),
                NumberOfNights = 15,
                CostVacationer = 1503,
                NumberOfVacationers = 3,
                WiFi = true,
                Surcharges = 1425.64m,
            };
            TourTest.Edit(test, test2);            
            var result = TourTest.GetList();
            Assert.Equal(test2, result[0]);
        }
        [Fact]
        public void DeleteButton()
        {
            TourBusiness TourTest = new();
            Tour test = new()
            {
                Direction = Direction.Turkey,
                Departure = DateTime.Now,
                NumberOfNights = 30,
                CostVacationer = 100,
                NumberOfVacationers = 2,
                WiFi = true,
                Surcharges = 450.32m,
            };
            TourTest.Add(test);
            TourTest.Delete(test);            
            var result = TourTest.GetList();
            Assert.Empty(result);
        }
    }
    }
