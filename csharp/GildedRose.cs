using System.Collections.Generic;

namespace csharp
{
  public class GildedRose
  {
    IList<Item> Items;
    public GildedRose(IList<Item> Items)
    {
      this.Items = Items;
    }

    public void UpdateQuality()
    {
      Item item;
      for (var i = 0; i < Items.Count; i++)
      {
        item = Items[i];

        if (item.Name == "Sulfuras, Hand of Ragnaros")
          continue;

        if (item.Quality > 0 && item.Quality < 50)
        {
          switch (item.Name)
          {
            case "Aged Brie":
              UpdateAgedBrieGoods(item);
              break;
            case "Backstage passes to a TAFKAL80ETC concert":
              UpdateBackstage(item);
              break;
            case "Conjured Mana Cake":
              UpdateConjuredGoods(item);
              break;
            default:
              UpdateNormalGoods(item);
              break;
          }
          item.SellIn = item.SellIn - 1;
        }

      }
    }
    public void UpdateNormalGoods(Item item)
    {
      if (item.SellIn > 0)
      {
        item.Quality = item.Quality - 1;
      }
      else if (item.Quality > 0 && item.SellIn < 0)
      {
        item.Quality = item.Quality - 2;
      }
    }

    public void UpdateConjuredGoods(Item item)
    {
      if (item.Quality > 1)
        item.Quality = item.Quality - 2;
    }

    public void UpdateAgedBrieGoods(Item item)
    {
      item.Quality = item.Quality + 1;
    }

    public void UpdateBackstage(Item item)
    {
      if (item.SellIn < 6)
      {
        item.Quality = item.Quality + 3;
      }
      else if (item.SellIn < 11)
      {
        item.Quality = item.Quality + 2;
      }
      else if (item.SellIn < 0)
      {
        item.Quality = 0;
      }
    }
  }
}
