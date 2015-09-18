using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart.Service.Chris
{
    public class PotterShopping
    {

        public double PotterCalculator(Dictionary<string, double> potterBooks)
        {
            double total = 0;
            int kindCount = 0;

            // 取得購買的種類數
            for (int i = 1; i <= potterBooks.Count; i++)
            {
                var key = "episode" + i;
                if (potterBooks[key] > 0)
                {
                    kindCount += 1;
                }
            }

            // 購買的總數量
            var bookCount = potterBooks.Where(x => x.Value > 0).Sum(x => x.Value);

            var data = potterBooks.Where(x => x.Value > 0).OrderBy(x => x.Value);

            // 只買一個種類，不打折
            if (kindCount == 1)
            {
                total = bookCount * 100;
            }

            // 買兩個種類，一組打九五折
            else if (kindCount == 2)
            {
                total = data.ElementAt(0).Value * 2 * 100 * 0.95;
                int kindCount2 = 0;
                for (int i = 0; i < data.Count(); i++)
                {
                    if ((data.ElementAt(i).Value - data.ElementAt(0).Value) > 0)
                    {
                        kindCount2 += 1;
                    }
                }
                if (kindCount2 == 1)
                {
                    total = total + (data.ElementAt(1).Value - data.ElementAt(0).Value) * 100;
                }
            }
            // 買三個種類，一組打九折
            else if (kindCount == 3)
            {
                total = data.ElementAt(0).Value * 3 * 100 * 0.9;

                int kindCount2 = 0;
                for (int i = 0; i < data.Count(); i++)
                {
                    if ((data.ElementAt(i).Value - data.ElementAt(0).Value) > 0)
                    {
                        kindCount2 += 1;
                    }
                }

                if (kindCount2 == 2)
                {
                    total = total + (data.ElementAt(1).Value - data.ElementAt(0).Value) * 2 * 100 * 0.95;
                    int kindCount3 = 0;
                    for (int i = 0; i < data.Count(); i++)
                    {
                        if ((data.ElementAt(i).Value - data.ElementAt(1).Value) > 0)
                        {
                            kindCount3 += 1;
                        }
                    }
                    if (kindCount3 == 1)
                    {
                        total = total + (data.ElementAt(2).Value - data.ElementAt(1).Value) * 100;
                    }
                }
                else if (kindCount2 == 1)
                {
                    total = total + (data.ElementAt(2).Value - data.ElementAt(1).Value) * 100;
                }
            }
            // 買四個種類，一組打八折
            else if (kindCount == 4)
            {
                total = data.ElementAt(0).Value * 4 * 100 * 0.8;

                int kindCount2 = 0;
                for (int i = 0; i < data.Count(); i++)
                {
                    if ((data.ElementAt(i).Value - data.ElementAt(0).Value) > 0)
                    {
                        kindCount2 += 1;
                    }
                }

                if (kindCount2 == 3)
                {
                    total = total + (data.ElementAt(1).Value - data.ElementAt(0).Value) * 3 * 100 * 0.9;

                    int kindCount3 = 0;
                    for (int i = 0; i < data.Count(); i++)
                    {
                        if ((data.ElementAt(i).Value - data.ElementAt(1).Value) > 0)
                        {
                            kindCount3 += 1;
                        }
                    }

                    if (kindCount3 == 2)
                    {
                        total = total + (data.ElementAt(2).Value - data.ElementAt(1).Value) * 2 * 100 * 0.95;
                        int kindCount4 = 0;
                        for (int i = 0; i < data.Count(); i++)
                        {
                            if ((data.ElementAt(i).Value - data.ElementAt(2).Value) > 0)
                            {
                                kindCount4 += 1;
                            }
                        }
                        if (kindCount4 == 1)
                        {
                            total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 100;
                        }
                    }
                    else if (kindCount3 == 1)
                    {
                        total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 100;
                    }
                }
                else if (kindCount2 == 2)
                {
                    total = total + (data.ElementAt(2).Value - data.ElementAt(1).Value) * 2 * 100 * 0.95;
                    int kindCount3 = 0;
                    for (int i = 0; i < data.Count(); i++)
                    {
                        if ((data.ElementAt(i).Value - data.ElementAt(2).Value) > 0)
                        {
                            kindCount3 += 1;
                        }
                    }
                    if (kindCount3 == 1)
                    {
                        total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 100;
                    }
                }
                else if (kindCount2 == 1)
                {
                    total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 100;
                }
            }
            // 買五個種類，一組打七五折
            else if (kindCount == 5)
            {
                total = data.ElementAt(0).Value * 5 * 100 * 0.75;

                int kindCount2 = 0;
                for (int i = 0; i < data.Count(); i++)
                {
                    if ((data.ElementAt(i).Value - data.ElementAt(0).Value) > 0)
                    {
                        kindCount2 += 1;
                    }
                }
                if (kindCount2 == 4)
                {
                    total = (data.ElementAt(1).Value - data.ElementAt(0).Value) * 4 * 100 * 0.8;

                    int kindCount3 = 0;
                    for (int i = 0; i < data.Count(); i++)
                    {
                        if ((data.ElementAt(i).Value - data.ElementAt(1).Value) > 0)
                        {
                            kindCount3 += 1;
                        }
                    }

                    if (kindCount3 == 3)
                    {
                        total = total + (data.ElementAt(2).Value - data.ElementAt(1).Value) * 3 * 100 * 0.9;

                        int kindCount4 = 0;
                        for (int i = 0; i < data.Count(); i++)
                        {
                            if ((data.ElementAt(i).Value - data.ElementAt(2).Value) > 0)
                            {
                                kindCount4 += 1;
                            }
                        }

                        if (kindCount4 == 2)
                        {
                            total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 2 * 100 * 0.95;
                            int kindCount5 = 0;
                            for (int i = 0; i < data.Count(); i++)
                            {
                                if ((data.ElementAt(i).Value - data.ElementAt(3).Value) > 0)
                                {
                                    kindCount5 += 1;
                                }
                            }
                            if (kindCount5 == 1)
                            {
                                total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                            }
                        }
                        else if (kindCount4 == 1)
                        {
                            total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                        }
                    }
                    else if (kindCount3 == 2)
                    {
                        total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 2 * 100 * 0.95;
                        int kindCount5 = 0;
                        for (int i = 0; i < data.Count(); i++)
                        {
                            if ((data.ElementAt(i).Value - data.ElementAt(3).Value) > 0)
                            {
                                kindCount5 += 1;
                            }
                        }
                        if (kindCount5 == 1)
                        {
                            total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                        }
                    }
                    else if (kindCount3 == 1)
                    {
                        total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                    }
                }
                else if (kindCount2 == 3)
                {
                    total = total + (data.ElementAt(2).Value - data.ElementAt(1).Value) * 3 * 100 * 0.9;

                    int kindCount3 = 0;
                    for (int i = 0; i < data.Count(); i++)
                    {
                        if ((data.ElementAt(i).Value - data.ElementAt(2).Value) > 0)
                        {
                            kindCount3 += 1;
                        }
                    }

                    if (kindCount3 == 2)
                    {
                        total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 2 * 100 * 0.95;
                        int kindCount4 = 0;
                        for (int i = 0; i < data.Count(); i++)
                        {
                            if ((data.ElementAt(i).Value - data.ElementAt(3).Value) > 0)
                            {
                                kindCount4 += 1;
                            }
                        }
                        if (kindCount4 == 1)
                        {
                            total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                        }
                    }
                    else if (kindCount3 == 1)
                    {
                        total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                    }
                }
                else if (kindCount2 == 2)
                {
                    total = total + (data.ElementAt(3).Value - data.ElementAt(2).Value) * 2 * 100 * 0.95;
                    int kindCount3 = 0;
                    for (int i = 0; i < data.Count(); i++)
                    {
                        if ((data.ElementAt(i).Value - data.ElementAt(3).Value) > 0)
                        {
                            kindCount3 += 1;
                        }
                    }
                    if (kindCount3 == 1)
                    {
                        total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                    }
                }
                else if (kindCount2 == 1)
                {
                    total = total + (data.ElementAt(4).Value - data.ElementAt(3).Value) * 100;
                }
            }
            return total;
        }
    }
}
