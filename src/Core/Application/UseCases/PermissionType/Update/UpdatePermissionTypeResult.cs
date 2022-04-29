﻿using N5.Domain.Dtos;
using System;

namespace N5.Application.UseCases.PermissionType.Update
{
    public class UpdatePermissionTypeResult
    {
        public int Id { get; set; }
        public string Name { get; set; }        

        public UpdatePermissionTypeResult(PermissionTypeDto permissionTypeDto)
        {
            Id = permissionTypeDto.Id;
            Name = permissionTypeDto.Name;
            
        }
    }
}
