﻿namespace WebShop.Core.Models
{
    public class PageRequestParams
    {
        const int maxAllowedPageSize = 50;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxAllowedPageSize) ? maxAllowedPageSize : value;
            }
        }
    }
}
