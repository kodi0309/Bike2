﻿namespace Transit;


public class SaleCreated
{
    // Sale.cs
    public Guid Id { get; set; }
    public string Status { get; set; }
    public DateTime? PublicationDate { get; set; }
    public string Author { get; set; }

    // Item.cs
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string ImageUrl { get; set; }

    // ItemProperties
    public List<Component> Frame { get; set; }
    public List<Component> Handlebar { get; set; }
    public List<Component> Brakes { get; set; }
    public List<Component> WheelsTires { get; set; }
    public List<Component> Seat { get; set; }
    public List<Component> DerailleursDrive { get; set; }
    public List<Component> AdditionalAccessories { get; set; }
}
