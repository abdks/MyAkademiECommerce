﻿namespace MyAkademiECommerce.Discount.Dtos
{
    public class ResultCouponDto
    {
        public int CouponID { get; set; }
        public string Code { get; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidDate { get; set; }

    }
}
