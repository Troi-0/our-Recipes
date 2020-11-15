namespace Recipes.Data.Models
{
    using System;

    using Microsoft.AspNetCore.Identity;

    using Recipes.Data.Common.Models;

    public class Ingredient : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
