﻿namespace RealEstate_Dapper_API.Tools
{
    public class GetCheckAppUserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public bool IsExist { get; set; }
    }
}
