﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Project.Application.Models.DTOs.DepartmantDTOs
{
    public class DepartmantCreateDTO
    {
        public string Name { get; set; }
        public Guid? CompanyId { get; set; }

        public Guid? DepartmantManagerId { get; set; }
    }
}
