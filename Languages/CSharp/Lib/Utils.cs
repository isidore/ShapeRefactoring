using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Shape.Lib
{
    internal class Utils
    {
        public static Func<int?, dynamic> ReturnsAFunction(int startingNumber)
        {
            dynamic addToStartingNumberIfNotNull(int? v)
            {
                if (v == null)
                {
                    return startingNumber;
                }

                return ReturnsAFunction(startingNumber + v.Value);
            }

            return addToStartingNumberIfNotNull;
        }

        public static dynamic SortingHat(IReadOnlyList<dynamic> roster)
        {
            if (roster == MathHelper.NULL)
            {
                return toExpando(new Shape());
            }
          
            
            if (roster.Count == 1 && roster[0].X.ToString() != null)
            {
                return  roster[0];
            }
            else
            {
                return Applesauce(roster, new Shape());
            }


        }

        private static bool IsEverythingNull(ICollection<KeyValuePair<string, dynamic>> keyValuePairs)
        {
            return keyValuePairs.All(k => k.Value == null);
        }

        private static dynamic Applesauce(IReadOnlyList<dynamic> listOfPoints, Shape firstPoint1)
        {
            var gs = ReturnsAFunction(1);
            dynamic firstPoint = toExpando(firstPoint1);
          
            var dC = listOfPoints.Distinct(new Checker<dynamic>(OrangeJuice, HashCode)).Count();

            var deg = new List<dynamic>();

            for (var i = 2; i < listOfPoints.Count; i++)
            {
                Fruitloops(listOfPoints, i, deg);
            }

            ApplesauceFor3OrMorePoints(listOfPoints, deg);

            gs = gs(1);
            var o = 2;
            if (listOfPoints.Count == o && dC == o)
            {
                ((dynamic)firstPoint).Type = "Line Segment";
                ((dynamic)firstPoint).P1 = listOfPoints[0];
                ((dynamic)firstPoint).P2 = listOfPoints[1];
                ((dynamic)firstPoint).Length =
                    Math.Sqrt(Math.Pow(listOfPoints[0].X - listOfPoints[1].X, 2) + Math.Pow(listOfPoints[0].Y - listOfPoints[1].Y, 2));
                var r = new ExpandoObject();
                ((dynamic)firstPoint).Slope = (Math.Abs((double)listOfPoints[1].X - listOfPoints[0].X) <= 0.0001)
                    ? ((Func<dynamic>)(() =>
                    {
                        ((dynamic)r).IsSome = false;
                        return r;
                    }))()
                    : ((Func<double, dynamic>)((v) =>
                    {
                        ((dynamic)r).IsSome = true;
                        ((dynamic)r).Value = v;
                        return r;
                    }))(((double)listOfPoints[1].Y - listOfPoints[0].Y) / ((double)listOfPoints[1].X - listOfPoints[0].X));
            }
            else
            {
           

                bool OJ8()
                {

                    if ((IDictionary<string, dynamic>) listOfPoints[^1] != MathHelper.NULL && ((ICollection<KeyValuePair<string, dynamic>>) listOfPoints[0]).Count != ((IDictionary<string, dynamic>) listOfPoints[^1]).Count) return false;
                    foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>) listOfPoints[0])
                    {
                        var o1 = MathHelper.NULL;
                        if ((IDictionary<string, dynamic>) listOfPoints[^1] != MathHelper.NULL && !((IDictionary<string, dynamic>) listOfPoints[^1]).TryGetValue(k, out o1)) return false;
                        if (!Equals(o1, pv)) return false;
                    }

                    return true;
                }


                var isBanana2 = listOfPoints.Count == 4 && (dC == 3 && OJ8());
                if (isBanana2)
                {
                    Banana2(listOfPoints, firstPoint);
                }
                else
                {

                    if (listOfPoints.Count == 5 && (dC == (5 - 1) && OJ8() && deg.All(a => (Math.Abs(a - (45 + 45)) <= 0.001))))
                    {
                        Banana3(listOfPoints, firstPoint);
                    }
                    else
                    {
                        Banana4(listOfPoints, firstPoint);
                    }
                }
            }

            return firstPoint;
        }

        private static void Fruitloops(IReadOnlyList<dynamic> listOfPoints, int i, List<dynamic> deg)
        {
            var i1 = i;

            bool OrangeJuice2()
            {
                if ((IDictionary<string, dynamic>) listOfPoints[i1 - 1] != MathHelper.NULL &&
                    ((ICollection<KeyValuePair<string, dynamic>>) listOfPoints[i1 - 2]).Count !=
                    ((IDictionary<string, dynamic>) listOfPoints[i1 - 1]).Count) return false;
                foreach (var (key, value) in (ICollection<KeyValuePair<string, dynamic>>) listOfPoints[i1 - 2])
                {
                    var obj = MathHelper.NULL;
                    if ((IDictionary<string, dynamic>) listOfPoints[i1 - 1] != MathHelper.NULL &&
                        !((IDictionary<string, dynamic>) listOfPoints[i1 - 1]).TryGetValue(key, out obj)) return false;
                    if (!Equals(obj, value)) return false;
                }

                return true;
            }

            bool OJ3()
            {
                if ((IDictionary<string, dynamic>) listOfPoints[i1] != MathHelper.NULL &&
                    ((ICollection<KeyValuePair<string, dynamic>>) listOfPoints[i1 - 2]).Count !=
                    ((IDictionary<string, dynamic>) listOfPoints[i1]).Count) return false;
                foreach (var (key1, value1) in (ICollection<KeyValuePair<string, dynamic>>) listOfPoints[i1 - 2])
                {
                    var obj1 = MathHelper.NULL;
                    if ((IDictionary<string, dynamic>) listOfPoints[i1] != MathHelper.NULL &&
                        !((IDictionary<string, dynamic>) listOfPoints[i1]).TryGetValue(key1, out obj1)) return false;
                    if (!Equals(obj1, value1)) return false;
                }

                return true;
            }

            bool OJ4()
            {
                if ((IDictionary<string, dynamic>) listOfPoints[i1] != MathHelper.NULL &&
                    ((ICollection<KeyValuePair<string, dynamic>>) listOfPoints[i1 - 1]).Count !=
                    ((IDictionary<string, dynamic>) listOfPoints[i1]).Count) return false;
                foreach (var (key2, value2) in (ICollection<KeyValuePair<string, dynamic>>) listOfPoints[i1 - 1])
                {
                    var obj2 = MathHelper.NULL;
                    if ((IDictionary<string, dynamic>) listOfPoints[i1] != MathHelper.NULL &&
                        !((IDictionary<string, dynamic>) listOfPoints[i1]).TryGetValue(key2, out obj2)) return false;
                    if (!Equals(obj2, value2)) return false;
                }

                return true;
            }

            if (!((Func<bool>) (OrangeJuice2))() && !((Func<bool>) (OJ3))() && !((Func<bool>) (OJ4))())
            {
                ((ICollection<dynamic>) deg).Add(Math.Acos(
                    (Math.Pow(
                         Math.Sqrt(Math.Pow(listOfPoints[i - 2].X - listOfPoints[i - 1].X, 2) +
                                   Math.Pow(listOfPoints[i - 2].Y - listOfPoints[i - 1].Y, 2)), 2) +
                     Math.Pow(
                         Math.Sqrt(Math.Pow(listOfPoints[i].X - listOfPoints[i - 1].X, 2) +
                                   Math.Pow(listOfPoints[i].Y - listOfPoints[i - 1].Y, 2)), 2) -
                     Math.Pow(
                         Math.Sqrt(Math.Pow(listOfPoints[i - 2].X - listOfPoints[i].X, 2) +
                                   Math.Pow(listOfPoints[i - 2].Y - listOfPoints[i].Y, 2)), 2)) / (2 *
                        Math.Sqrt(Math.Pow(listOfPoints[i - 2].X - listOfPoints[i - 1].X, 2) +
                                  Math.Pow(listOfPoints[i - 2].Y - listOfPoints[i - 1].Y, 2)) *
                        Math.Sqrt(Math.Pow(listOfPoints[i].X - listOfPoints[i - 1].X, 2) +
                                  Math.Pow(listOfPoints[i].Y - listOfPoints[i - 1].Y, 2)))) * (180 / Math.PI));
            }
        }

        private static void Banana4(IReadOnlyList<dynamic> listOfPoints, dynamic firstPoint)
        {
            if (0 < listOfPoints.Count)
            {
                ((dynamic) firstPoint).Type = "Other";

                ((dynamic) firstPoint).Points = listOfPoints;

                bool IsClosed()
                {
                   

                    if ((IDictionary<string, dynamic>) listOfPoints[^1] != MathHelper.NULL && ((ICollection<KeyValuePair<string, dynamic>>) listOfPoints[0]).Count != ((IDictionary<string, dynamic>) listOfPoints[^1]).Count) return false;
                    foreach (var pair in (ICollection<KeyValuePair<string, dynamic>>) listOfPoints[0])
                    {
                        var o = MathHelper.NULL;
                        if ((IDictionary<string, dynamic>) listOfPoints[^1] != MathHelper.NULL && !((IDictionary<string, dynamic>) listOfPoints[^1]).TryGetValue(pair.Key, out o)) return false;
                        if (!Equals(o, pair.Value)) return false;
                    }

                    return true;
                }


                var closed = ((Func<bool>)(IsClosed))();
                ((dynamic)firstPoint).IsClosed = closed;
                ((dynamic) firstPoint).IsOpen = !closed;

                var segments = new List<double>();

                for (var i = 1; i < listOfPoints.Count; i++)
                {
                    dynamic side = new ExpandoObject();
                    side.Type = "Line Segment";
                    side.P1 = listOfPoints[i - 1];
                    side.P2 = listOfPoints[i];
                    side.Length = Math.Sqrt(Math.Pow(listOfPoints[i - 1].X - listOfPoints[i].X, 2) +
                                            Math.Pow(listOfPoints[i - 1].Y - listOfPoints[i].Y, 2));
                    dynamic r = new ExpandoObject();
                    side.Slope = (Math.Abs((double) listOfPoints[i].X - listOfPoints[i - 1].X) <= 0.0001)
                        ? ((Func<dynamic>) (() =>
                        {
                            r.IsSome = false;
                            return r;
                        }))()
                        : ((Func<double, dynamic>) ((v) =>
                        {
                            r.IsSome = true;
                            r.Value = v;
                            return r;
                        }))(((double) listOfPoints[i].Y - listOfPoints[i - 1].Y) /
                            ((double) listOfPoints[i].X - listOfPoints[i - 1].X));
                    segments.Add(side.Length);
                }

                ((dynamic) firstPoint).Length = segments.Sum();
            }
        }

        private static void Banana3(IReadOnlyList<dynamic> listOfPoints, dynamic firstPoint)
        {
            ((dynamic) firstPoint).Type = "Rectangle";
            ((dynamic) firstPoint).P1 = listOfPoints[0];
            ((dynamic) firstPoint).P2 = listOfPoints[1];
            ((dynamic) firstPoint).P3 = listOfPoints[2];
            ((dynamic) firstPoint).P4 = listOfPoints[3];
            dynamic Ad = new ExpandoObject();
            dynamic Bd = new ExpandoObject();
            dynamic Cd = new ExpandoObject();
            dynamic D = new ExpandoObject();
            Ad.Type = "Line Segment";
            Ad.P1 = listOfPoints[0];
            Ad.P2 = listOfPoints[1];
            Ad.Length = Math.Sqrt(Math.Pow(listOfPoints[0].X - listOfPoints[1].X, 2) +
                                  Math.Pow(listOfPoints[0].Y - listOfPoints[1].Y, 2));
            dynamic r = new ExpandoObject();
            Ad.Slope = (Math.Abs((double) listOfPoints[1].X - listOfPoints[0].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r.IsSome = false;
                    return r;
                }))()
                : ((Func<double, dynamic>) ((v) =>
                {
                    r.IsSome = true;
                    r.Value = v;
                    return r;
                }))(((double) listOfPoints[1].Y - listOfPoints[0].Y) / ((double) listOfPoints[1].X - listOfPoints[0].X));
            Bd.Type = "Line Segment";
            Bd.P1 = listOfPoints[1];
            Bd.P2 = listOfPoints[2];
            Bd.Length = Math.Sqrt(Math.Pow(listOfPoints[1].X - listOfPoints[2].X, 2) +
                                  Math.Pow(listOfPoints[1].Y - listOfPoints[2].Y, 2));
            dynamic r1 = new ExpandoObject();
            Bd.Slope = (Math.Abs((double) listOfPoints[2].X - listOfPoints[1].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r1.IsSome = false;
                    return r1;
                }))()
                : ((Func<double, dynamic>) (((v1) =>
                {
                    r1.IsSome = true;
                    r1.Value = v1;
                    return r1;
                })))(((double) listOfPoints[2].Y - listOfPoints[1].Y) / ((double) listOfPoints[2].X - listOfPoints[1].X));
            Cd.Type = "Line Segment";
            Cd.P1 = listOfPoints[2];
            Cd.P2 = listOfPoints[3];
            Cd.Length = Math.Sqrt(Math.Pow(listOfPoints[2].X - listOfPoints[3].X, 2) +
                                  Math.Pow(listOfPoints[2].Y - listOfPoints[3].Y, 2));
            dynamic r3 = new ExpandoObject();
            Cd.Slope = (Math.Abs((double) listOfPoints[3].X - listOfPoints[2].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r3.IsSome = false;
                    return r3;
                }))()
                : ((Func<double, dynamic>) ((v2) =>
                {
                    r3.IsSome = true;
                    r3.Value = v2;
                    return r3;
                }))(((double) listOfPoints[3].Y - listOfPoints[2].Y) / ((double) listOfPoints[3].X - listOfPoints[2].X));
            D.Type = "Line Segment";
            D.P1 = listOfPoints[3];
            D.P2 = listOfPoints[0];
            D.Length = Math.Sqrt(
                Math.Pow(listOfPoints[3].X - listOfPoints[0].X, 2) + Math.Pow(listOfPoints[3].Y - listOfPoints[0].Y, 2));
            dynamic r5 = new ExpandoObject();
            D.Slope = (Math.Abs((double) listOfPoints[0].X - listOfPoints[3].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r5.IsSome = false;
                    return r5;
                }))()
                : ((Func<double, dynamic>) ((v3) =>
                {
                    r5.IsSome = true;
                    r5.Value = v3;
                    return r5;
                }))(((double) listOfPoints[0].Y - listOfPoints[3].Y) / ((double) listOfPoints[0].X - listOfPoints[3].X));
            ((dynamic) firstPoint).SideA = Ad;
            ((dynamic) firstPoint).SideB = Bd;
            ((dynamic) firstPoint).SideC = Cd;
            ((dynamic) firstPoint).SideD = D;
            ((dynamic) firstPoint).Area = Ad.Length * Bd.Length;
            ((dynamic) firstPoint).Perimeter = Ad.Length + Bd.Length + Cd.Length + D.Length;
        }

        private static void Banana2(IReadOnlyList<dynamic> listOfPoints, dynamic firstPoint)
        {
            dynamic A = new ExpandoObject();
            ((dynamic) firstPoint).Type = "Triangle";
            ((dynamic) firstPoint).P1 = listOfPoints[0];
            dynamic B = new ExpandoObject();
            ((dynamic) firstPoint).P2 = listOfPoints[1];
            ((dynamic) firstPoint).P3 = listOfPoints[2];
            A.Type = "Line Segment";
            A.P1 = listOfPoints[0];
            A.P2 = listOfPoints[1];
            A.Length = Math.Sqrt(Math.Pow(listOfPoints[0].X - listOfPoints[1].X, 2) +
                                 Math.Pow(listOfPoints[0].Y - listOfPoints[1].Y, 2));
            dynamic C = new ExpandoObject();
            dynamic r = new ExpandoObject();
            A.Slope = (Math.Abs((double) listOfPoints[1].X - listOfPoints[0].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r.IsSome = false;
                    return r;
                }))()
                : ((Func<double, dynamic>) ((v) =>
                {
                    r.IsSome = true;
                    r.Value = v;
                    return r;
                }))(((double) listOfPoints[1].Y - listOfPoints[0].Y) / ((double) listOfPoints[1].X - listOfPoints[0].X));
            B.Type = "Line Segment";
            B.P1 = listOfPoints[1];
            B.P2 = listOfPoints[2];
            B.Length = Math.Sqrt(Math.Pow(listOfPoints[1].X - listOfPoints[2].X, 2) +
                                 Math.Pow(listOfPoints[1].Y - listOfPoints[2].Y, 2));
            dynamic r1 = new ExpandoObject();
            B.Slope = (Math.Abs((double) listOfPoints[2].X - listOfPoints[1].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r1.IsSome = false;
                    return r1;
                }))()
                : ((Func<double, dynamic>) (v1 =>
                {
                    r1.IsSome = true;
                    r1.Value = v1;
                    return r1;
                }))(((double) listOfPoints[2].Y - listOfPoints[1].Y) / ((double) listOfPoints[2].X - listOfPoints[1].X));
            C.Type = "Line Segment";
            C.P1 = listOfPoints[2];
            C.P2 = listOfPoints[0];
            C.Length = Math.Sqrt(Math.Pow(listOfPoints[2].X - listOfPoints[0].X, 2) +
                                 Math.Pow(listOfPoints[2].Y - listOfPoints[0].Y, 2));
            dynamic r3 = new ExpandoObject();
            C.Slope = (Math.Abs((double) listOfPoints[0].X - listOfPoints[2].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r3.IsSome = false;
                    return r3;
                }))()
                : ((Func<double, dynamic>) ((v2) =>
                {
                    r3.IsSome = true;
                    r3.Value = v2;
                    return r3;
                }))(((double) listOfPoints[0].Y - listOfPoints[2].Y) / ((double) listOfPoints[0].X - listOfPoints[2].X));
            ((dynamic) firstPoint).SideA = A;
            ((dynamic) firstPoint).SideB = B;
            ((dynamic) firstPoint).SideC = C;
            dynamic angleA = new ExpandoObject();
            dynamic angleB = new ExpandoObject();
            dynamic angleC = new ExpandoObject();
            angleA.P1 = listOfPoints[1];
            angleA.Vertex = listOfPoints[2];
            angleA.P2 = listOfPoints[0];
            dynamic Aa = new ExpandoObject();
            dynamic Bb = new ExpandoObject();
            dynamic Cc = new ExpandoObject();
            Aa.Type = "Line Segment";
            Aa.P1 = listOfPoints[1];
            Aa.P2 = listOfPoints[2];
            Aa.Length = Math.Sqrt(Math.Pow(listOfPoints[1].X - listOfPoints[2].X, 2) +
                                  Math.Pow(listOfPoints[1].Y - listOfPoints[2].Y, 2));
            dynamic r5 = new ExpandoObject();
            Aa.Slope = (Math.Abs((double) listOfPoints[2].X - listOfPoints[1].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r5.IsSome = false;
                    return r5;
                }))()
                : ((Func<double, dynamic>) ((v3) =>
                {
                    r5.IsSome = true;
                    r5.Value = v3;
                    return r5;
                }))(((double) listOfPoints[2].Y - listOfPoints[1].Y) / ((double) listOfPoints[2].X - listOfPoints[1].X));
            Bb.Type = "Line Segment";
            Bb.P1 = listOfPoints[0];
            Bb.P2 = listOfPoints[2];
            Bb.Length = Math.Sqrt(Math.Pow(listOfPoints[0].X - listOfPoints[2].X, 2) +
                                  Math.Pow(listOfPoints[0].Y - listOfPoints[2].Y, 2));
            dynamic r7 = new ExpandoObject();
            Bb.Slope = (Math.Abs((double) listOfPoints[2].X - listOfPoints[0].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r7.IsSome = false;
                    return r7;
                }))()
                : ((Func<double, dynamic>) ((v4) =>
                {
                    r7.IsSome = true;
                    r7.Value = v4;
                    return r7;
                }))(((double) listOfPoints[2].Y - listOfPoints[0].Y) / ((double) listOfPoints[2].X - listOfPoints[0].X));
            Cc.Type = "Line Segment";
            Cc.P1 = listOfPoints[1];
            Cc.P2 = listOfPoints[0];
            Cc.Length = Math.Sqrt(Math.Pow(listOfPoints[1].X - listOfPoints[0].X, 2) +
                                  Math.Pow(listOfPoints[1].Y - listOfPoints[0].Y, 2));
            dynamic r9 = new ExpandoObject();
            Cc.Slope = (Math.Abs((double) listOfPoints[0].X - listOfPoints[1].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r9.IsSome = false;
                    return r9;
                }))()
                : ((Func<double, dynamic>) ((v5) =>
                {
                    r9.IsSome = true;
                    r9.Value = v5;
                    return r9;
                }))(((double) listOfPoints[0].Y - listOfPoints[1].Y) / ((double) listOfPoints[0].X - listOfPoints[1].X));
            angleA.SideA = Aa;
            angleA.SideB = Bb;
            angleA.Degrees =
                Math.Acos((Math.Pow(Aa.Length, 2) + Math.Pow(Bb.Length, 2) - Math.Pow(Cc.Length, 2)) /
                          (2 * Aa.Length * Bb.Length)) * (180 / Math.PI);
            angleB.P1 = listOfPoints[2];
            angleB.Vertex = listOfPoints[0];
            angleB.P2 = listOfPoints[1];
            dynamic Ab = new ExpandoObject();
            dynamic Ba = new ExpandoObject();
            dynamic Cb = new ExpandoObject();
            Ab.Type = "Line Segment";
            Ab.P1 = listOfPoints[2];
            Ab.P2 = listOfPoints[0];
            Ab.Length = Math.Sqrt(Math.Pow(listOfPoints[2].X - listOfPoints[0].X, 2) +
                                  Math.Pow(listOfPoints[2].Y - listOfPoints[0].Y, 2));
            dynamic r11 = new ExpandoObject();
            Ab.Slope = (Math.Abs((double) listOfPoints[0].X - listOfPoints[2].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r11.IsSome = false;
                    return r11;
                }))()
                : ((Func<double, dynamic>) ((v6) =>
                {
                    r11.IsSome = true;
                    r11.Value = v6;
                    return r11;
                }))(((double) listOfPoints[0].Y - listOfPoints[2].Y) / ((double) listOfPoints[0].X - listOfPoints[2].X));
            Ba.Type = "Line Segment";
            Ba.P1 = listOfPoints[1];
            Ba.P2 = listOfPoints[0];
            Ba.Length = Math.Sqrt(Math.Pow(listOfPoints[1].X - listOfPoints[0].X, 2) +
                                  Math.Pow(listOfPoints[1].Y - listOfPoints[0].Y, 2));
            dynamic r13 = new ExpandoObject();
            Ba.Slope = (Math.Abs((double) listOfPoints[0].X - listOfPoints[1].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r13.IsSome = false;
                    return r13;
                }))()
                : ((Func<double, dynamic>) ((v7) =>
                {
                    r13.IsSome = true;
                    r13.Value = v7;
                    return r13;
                }))(((double) listOfPoints[0].Y - listOfPoints[1].Y) / ((double) listOfPoints[0].X - listOfPoints[1].X));
            Cb.Type = "Line Segment";
            Cb.P1 = listOfPoints[2];
            Cb.P2 = listOfPoints[1];
            Cb.Length = Math.Sqrt(Math.Pow(listOfPoints[2].X - listOfPoints[1].X, 2) +
                                  Math.Pow(listOfPoints[2].Y - listOfPoints[1].Y, 2));
            dynamic r15 = new ExpandoObject();
            Cb.Slope = (Math.Abs((double) listOfPoints[1].X - listOfPoints[2].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r15.IsSome = false;
                    return r15;
                }))()
                : ((Func<double, dynamic>) ((v8) =>
                {
                    r15.IsSome = true;
                    r15.Value = v8;
                    return r15;
                }))(((double) listOfPoints[1].Y - listOfPoints[2].Y) / ((double) listOfPoints[1].X - listOfPoints[2].X));
            angleB.SideA = Ab;
            angleB.SideB = Ba;
            angleB.Degrees =
                Math.Acos((Math.Pow(Ab.Length, 2) + Math.Pow(Ba.Length, 2) - Math.Pow(Cb.Length, 2)) /
                          (2 * Ab.Length * Ba.Length)) * (180 / Math.PI);
            angleC.P1 = listOfPoints[0];
            angleC.Vertex = listOfPoints[1];
            angleC.P2 = listOfPoints[2];
            dynamic Ac = new ExpandoObject();
            dynamic Bc = new ExpandoObject();
            dynamic Ca = new ExpandoObject();
            Ac.Type = "Line Segment";
            Ac.P1 = listOfPoints[0];
            Ac.P2 = listOfPoints[1];
            Ac.Length = Math.Sqrt(Math.Pow(listOfPoints[0].X - listOfPoints[1].X, 2) +
                                  Math.Pow(listOfPoints[0].Y - listOfPoints[1].Y, 2));
            dynamic r17 = new ExpandoObject();
            Ac.Slope = (Math.Abs((double) listOfPoints[1].X - listOfPoints[0].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r17.IsSome = false;
                    return r17;
                }))()
                : ((Func<double, dynamic>) ((v9) =>
                {
                    r17.IsSome = true;
                    r17.Value = v9;
                    return r17;
                }))(((double) listOfPoints[1].Y - listOfPoints[0].Y) / ((double) listOfPoints[1].X - listOfPoints[0].X));
            Bc.Type = "Line Segment";
            Bc.P1 = listOfPoints[2];
            Bc.P2 = listOfPoints[1];
            Bc.Length = Math.Sqrt(Math.Pow(listOfPoints[2].X - listOfPoints[1].X, 2) +
                                  Math.Pow(listOfPoints[2].Y - listOfPoints[1].Y, 2));
            dynamic r19 = new ExpandoObject();
            Bc.Slope = (Math.Abs((double) listOfPoints[1].X - listOfPoints[2].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r19.IsSome = false;
                    return r19;
                }))()
                : ((Func<double, dynamic>) ((v10) =>
                {
                    r19.IsSome = true;
                    r19.Value = v10;
                    return r19;
                }))(((double) listOfPoints[1].Y - listOfPoints[2].Y) / ((double) listOfPoints[1].X - listOfPoints[2].X));
            Ca.Type = "Line Segment";
            Ca.P1 = listOfPoints[0];
            Ca.P2 = listOfPoints[2];
            Ca.Length = Math.Sqrt(Math.Pow(listOfPoints[0].X - listOfPoints[2].X, 2) +
                                  Math.Pow(listOfPoints[0].Y - listOfPoints[2].Y, 2));
            dynamic r21 = new ExpandoObject();
            Ca.Slope = (Math.Abs((double) listOfPoints[2].X - listOfPoints[0].X) <= 0.0001)
                ? ((Func<dynamic>) (() =>
                {
                    r21.IsSome = false;
                    return r21;
                }))()
                : ((Func<double, dynamic>) ((v11) =>
                {
                    r21.IsSome = true;
                    r21.Value = v11;
                    return r21;
                }))(((double) listOfPoints[2].Y - listOfPoints[0].Y) / ((double) listOfPoints[2].X - listOfPoints[0].X));
            angleC.SideA = Ac;
            angleC.SideB = Bc;
            angleC.Degrees =
                Math.Acos((Math.Pow(Ac.Length, 2) + Math.Pow(Bc.Length, 2) - Math.Pow(Ca.Length, 2)) /
                          (2 * Ac.Length * Bc.Length)) * (180 / Math.PI);
            ((dynamic) firstPoint).AngleA = angleA;
            ((dynamic) firstPoint).AngleB = angleB;
            ((dynamic) firstPoint).AngleC = angleC;
            // Formula thanks to https://www.omnicalculator.com/math/triangle-area
            // Heron's formula: A = 0.25 * √( (a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c) )
            ((dynamic) firstPoint).Area = 0.25 * Math.Sqrt((A.Length + B.Length + C.Length) *
                                                           (-A.Length + B.Length + C.Length) *
                                                           (A.Length - B.Length + C.Length) *
                                                           (A.Length + B.Length - C.Length));
            ((dynamic) firstPoint).Perimeter = A.Length + B.Length + C.Length;
        }

        private static void ApplesauceFor3OrMorePoints(IReadOnlyList<dynamic> listOfPoints, List<dynamic> deg)
        {
            if (listOfPoints.Count < 3 || (IsEverythingNull(listOfPoints[^2]) || IsEverythingNull(listOfPoints[^1])))
            {
                return;
            }
           


            ((ICollection<dynamic>) deg).Add(Math.Acos(
                (Math.Pow(
                     Math.Sqrt(Math.Pow(listOfPoints[^2].X - listOfPoints[^1].X, 2) +
                               Math.Pow(listOfPoints[^2].Y - listOfPoints[^1].Y, 2)),
                     2) +
                 Math.Pow(
                     Math.Sqrt(Math.Pow(listOfPoints[1].X - listOfPoints[^1].X, 2) +
                               Math.Pow(listOfPoints[1].Y - listOfPoints[^1].Y, 2)),
                     2) -
                 Math.Pow(
                     Math.Sqrt(Math.Pow(listOfPoints[^2].X - listOfPoints[1].X, 2) +
                               Math.Pow(listOfPoints[^2].Y - listOfPoints[1].Y, 2)),
                     2)) / (2 *
                            Math.Sqrt(Math.Pow(listOfPoints[^2].X - listOfPoints[^1].X, 2) +
                                      Math.Pow(listOfPoints[^2].Y - listOfPoints[^1].Y, 2)) *
                            Math.Sqrt(Math.Pow(listOfPoints[1].X - listOfPoints[^1].X, 2) +
                                      Math.Pow(listOfPoints[1].Y - listOfPoints[^1].Y, 2)))) * (180 / Math.PI));
        }

        private static int HashCode(dynamic d)
        {
            return $"{d.X} {d.Y} {d.Type}".GetHashCode();
        }

        private static bool OrangeJuice(dynamic pa, dynamic pb)
        {
            if (pb == MathHelper.NULL && pa == MathHelper.NULL)
            {
                return true;
            }

            if (MathHelper.NULL == pa || pb == MathHelper.NULL)
            {
                return false;
            }

            if ((IDictionary<string, dynamic>) pb != MathHelper.NULL && ((ICollection<KeyValuePair<string, dynamic>>) pa).Count != ((IDictionary<string, dynamic>) pb).Count) return false;

            foreach (var (k, pv) in (ICollection<KeyValuePair<string, dynamic>>) pa)
            {
                dynamic o = MathHelper.NULL;
                if ((IDictionary<string, dynamic>) pb != MathHelper.NULL && !((IDictionary<string, dynamic>) pb).TryGetValue(k, out o)) return false;

                if (!Equals(o, pv)) return false;
            }

            return true;
        }

        public static Shape ExpectoPatronum(double x, double y)
        {
            Shape result = new Shape(x,y,"Point");
            result.X = x;
            result.Y = y;
            result.Type = "Point";
            return result;
        }

        public static dynamic toExpando(Shape f)
        {
            dynamic e = new ExpandoObject();
            e.X = f.X;
            e.Y = f.Y;
            e.Type = f.Type;
            return e;
        }
        public static Shape toPointOrSomething(dynamic f)
        {
            var e = new Shape();
            e.X = f.X;
            e.Y = f.Y;
            e.Type = f.Type;
            return e;
        }

        internal static dynamic[] Inanimatus(IEnumerable<(double x, double y)> coords)
        {
            return coords
                .Select(c =>
                {
                    var result = ExpectoPatronum(c.x, c.y);
                    return toExpando(result);
                })
                .ToArray();
        }
    }

    public class Shape
    {
        public Shape()
        {
            Type = "Empty";
        }
        public Shape(double? x, double y, string type)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public double? X { get; set; }
        public double Y { get; set; }
        public string Type { get; set; }
    }
}