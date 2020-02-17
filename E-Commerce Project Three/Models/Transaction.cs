﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Commerce_Project_Three.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Completeness { get; set; } = false;
    }
}