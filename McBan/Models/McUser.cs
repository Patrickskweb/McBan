using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McBan.Models {
    public class McUser {
        
        public McUser() {
            Expired = false;
        }

        public int Id { get; set; }

        public string UUID { get; set; } //Minecraft UUID
        public string BannedBy { get; set; } //Will also be set to a UUID
        public string BannedByUsername { get; set; }
        public DateTime BannedOn { get; set; } //Date and time user was banned.
        public DateTime BannedUntil { get; set; } //Date and time the ban will expire
        public string Username { get; set; } //Minecraft username at time of ban, can be updated/verified by button on the page.
        public string Reason { get; set; } //Reason for ban TODO: Char limit
        public string Notes { get; set; } //Additional notes to the ban (added on the individual ban page, can not be added from the game)
        public bool Expired { get; set; } //Default: false. If true the ban is not in effect anymore, and can only be found by searing for old bans. An entry will never be removed from the database.

        //public string ModifiedBy { get; set; } //Shows the user(s) that changed this entry. TODO: Implement
 
    }
}