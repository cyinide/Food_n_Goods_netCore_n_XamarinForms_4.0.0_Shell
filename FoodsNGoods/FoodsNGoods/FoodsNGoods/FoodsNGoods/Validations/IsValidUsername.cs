﻿using FoodsNGoods.Validations.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodsNGoods.Validations
{
    public class IsValidUsername<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value == null)
                return false;

            var str = value as string;

            //return (Regex.Match(str, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success);
            return !string.IsNullOrEmpty(str) && str.Length > 7;
        }
    }

    public static partial class PropertyValidationExtensions
    {
        public static void AddEmailValidation(this ValidatableObject<string> property) => property.Validations.Add(new IsValidUsername<string> { ValidationMessage = "Invalid username or phone number!" }); //Translation and resource file needed
    }
}
