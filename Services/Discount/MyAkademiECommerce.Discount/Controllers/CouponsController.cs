﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAkademiECommerce.Discount.Dtos;
using MyAkademiECommerce.Discount.Services;

namespace MyAkademiECommerce.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public CouponsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> CouponsList()
        {
            var values = await _discountService.GetResultCouponAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoupon(CreateCouponDto createCouponDto)
        {
            await _discountService.CreateCouponAsync(createCouponDto);
            return Ok("Kupon Başarıyla Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCoupon(int id)
        {
            await _discountService.DeleteCouponAsync(id);
            return Ok("Kupon Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoupon(int id)
        {
            var values = await _discountService.GetCouponById(id);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            await _discountService.UpdateCouponAsync(updateCouponDto);
            return Ok("Güncelleme Yapıldı");
        }
    }
}
