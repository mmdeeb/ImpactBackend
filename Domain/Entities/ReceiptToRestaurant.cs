namespace Domain.Entities;

public class ReceiptToRestaurant : Receipt
{

    public RestaurantAccount? RestaurantAccount { get; set; }
    public int RestaurantAccountId { get; set; }
}
