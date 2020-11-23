using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class EditViewModel
    {
        public List<double> FontSizes { get; } = new List<double>()
        {
            8,
            9,
            10,
            11,
            12,
            14,
            16,
            18,
            20,
            24,
            28,
            36,
            48,
            72
        };

        public List<string> TestMethods { get; set; }

        public string SelectedMethod { get; set; } = "A";

        public EditViewModel()
        {
            TestMethods = new List<string>();
            TestMethods.AddRange( new []{"A","B","C"});
        }
    }
}
