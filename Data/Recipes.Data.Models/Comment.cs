namespace Recipes.Data.Models
{
    using System;

    using Microsoft.AspNetCore.Identity;

    using Recipes.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public string Content { get; set; }

        public ApplicationUser Author { get; set; }

        public Recipe Recipe { get; set; }

        public int Rating { get; set; }
    }
}
