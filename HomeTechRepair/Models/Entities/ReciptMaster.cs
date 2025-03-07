﻿using HomeTechRepair.Models.Identiy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeTechRepair.Models.Entities
{
    public class ReciptMaster
    {
        [Key]
        public Guid Id { get; set; }
        public double TotalAmount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string UserId { get; set; }
        public Guid SupportTicketId { get; set; }
        public bool isInvoiced { get; set; } = false;
        public bool isPaid { get; set; } = false;
        public List<ReciptDetail> ReciptDetails { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; }

        [ForeignKey(nameof(SupportTicketId))]
        public virtual SupportTicket SupportTicket { get; set; }
    }
}
