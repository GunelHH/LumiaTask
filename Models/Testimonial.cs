using System;
using LumiaProject.Models.Base;

namespace LumiaProject.Models
{
	public class Testimonial:BaseEntity
	{
        public string Desc { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public int PositionId { get; set; }

        public Position Position { get; set; }
    }
}

