
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Project7
{

using System;
    using System.Collections.Generic;
    
public partial class Reservation
{

    public int id { get; set; }

    public string user_id { get; set; }

    public Nullable<int> fk_date { get; set; }

    public Nullable<int> flag_break { get; set; }

    public Nullable<int> fk_table { get; set; }

    public Nullable<int> counter { get; set; }

    public Nullable<int> fk_time { get; set; }

    public Nullable<int> flag_lunch { get; set; }

    public Nullable<int> flag_dinner { get; set; }

    public Nullable<System.DateTime> datett { get; set; }

    public Nullable<int> Fk_category { get; set; }



    public virtual AspNetUser AspNetUser { get; set; }

    public virtual Date Date { get; set; }

    public virtual Table Table { get; set; }

    public virtual Time Time { get; set; }

}

}
