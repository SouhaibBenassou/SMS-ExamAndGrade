using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
    }
}
