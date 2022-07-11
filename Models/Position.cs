using System;
using System.Collections.Generic;
using LumiaProject.Models.Base;

namespace LumiaProject.Models
{
	public class Position:BaseEntity
	{
        public string Name { get; set; }

        public List<Testimonial> testimonial { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
