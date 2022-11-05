using GitImprov.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.Tests.Models
{
    public class Test
    {
        [NotMapped] private GitImprovContext db = new GitImprovContext();

        public int Id { get; set; }
        public string? Text { get; set; }

    }
}
