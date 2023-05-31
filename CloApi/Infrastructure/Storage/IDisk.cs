using CloApi.Infrastructure.Network;
using CloApi.Infrastructure.ServerObjects;
using System;
using System.Collections.Generic;


namespace CloApi.Infrastructure.Storage
{
    public interface IDisk
    {
        public Server? AttachedToServer { get; set; }
        public bool? Bootable { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? Id { get; set; }
        public List<Link>? Links { get; set; }
        public string? Name { get; set; }
        public int? Size { get; set; }
    }
}
