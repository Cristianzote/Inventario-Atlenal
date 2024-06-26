﻿using System;

namespace Access.API
{
    public class Category
    {
        public int ID_CATEGORY { get; set; }
        public string NAME { get; set; }
        public DateTimeOffset DATE { get; set; }
    }

    public enum CategoryType
    {
        SODA = 1,
        ALCOHOLIC = 2,
        SNACK = 3,
        OTHER = 4,
        DRINK = 5,
        ALL
    }
}
