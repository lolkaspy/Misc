using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLab
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Node<Network>> nodes = new List<Node<Network>>() { };
            List<Edge<Network>> edges = new List<Edge<Network>>() { };
            


            var n1 = new Node<Network>()
            {
                Id = 1,
                Value = new Network() { Id = 1, Name = "FirstNetwork" },
                Text = "1",
                Cx = 150,
                Cy = 75
            };
            Console.WriteLine($"{n1.Id} {n1.Value.Id} {n1.Value.Name} {n1.Text}");

            var n2 = new Node<Network>()
            {
                Id = 2,
                Value = new Network() { Id = 2, Name = "SecondNetwork" },
                Text = "2",
                Cx = 400,
                Cy = 100
            };

            var n3 = new Node<Network>()
            {
                Id = 3,
                Value = new Network() { Id = 3, Name = "ThirdNetwork" },
                Text = "3",
                Cx = 275,
                Cy = 225
            };

            var n4 = new Node<Network>()
            {
                Id = 4,
                Value = new Network() { Id = 4, Name = "FourthNetwork" },
                Text = "4",
                Cx = 225,
                Cy = 350
            };

            var n5 = new Node<Network>()
            {
                Id = 5,
                Value = new Network() { Id = 5, Name = "FifthNetwork" },
                Text = "5",
                Cx = 350,
                Cy = 375
            };

            nodes.Add(n1);
            nodes.Add(n2);
            nodes.Add(n3);
            nodes.Add(n4);
            nodes.Add(n5);

            edges.Add(new Edge<Network>() { Weight = 47, NodeFirst = n1, NodeSecond = n2, Cx1= n1.Cx+40, Cy1=n1.Cy, Cx2=n2.Cx-50, Cy2=n2.Cy });
            edges.Add(new Edge<Network>() { Weight = 53, NodeFirst = n2, NodeSecond = n3, Cx1 = n2.Cx-20, Cy1 = n2.Cy + 32, Cx2 = n3.Cx + 35, Cy2 = n3.Cy - 35 });
            edges.Add(new Edge<Network>() { Weight = 91, NodeFirst = n3, NodeSecond = n5, Cx1 = n3.Cx + 15, Cy1 = n3.Cy+40, Cx2 = n5.Cx-20, Cy2 = n5.Cy - 45 });
            edges.Add(new Edge<Network>() { Weight = 23, NodeFirst = n4, NodeSecond = n5, Cx1 = n4.Cx +40, Cy1 = n4.Cy, Cx2 = n5.Cx-50, Cy2 = n5.Cy-10 });
            edges.Add(new Edge<Network>() { Weight = 72, NodeFirst = n5, NodeSecond = n2, Cx1 = n5.Cx+5, Cy1 = n5.Cy - 39, Cx2 = n2.Cx, Cy2 = n2.Cy + 50 });
            edges.Add(new Edge<Network>() { Weight = 47, NodeFirst = n3, NodeSecond = n1, Cx1 = n3.Cx-20, Cy1 = n3.Cy - 35, Cx2 = n1.Cx+35, Cy2 = n1.Cy + 35 });
         

            Graph<Network> g = new Graph<Network>(nodes, edges);

            Console.WriteLine(g.Nodes.Count);
            Console.WriteLine(g.Edges.Count);
            PaintSVG(g);
            Console.ReadLine();

        }
        static void PaintSVG(Graph<Network> g)
        {

            string s = "<!DOCTYPE html><html lang='ru'><head><meta charset='utf-8'/></head><body>";
            s += "<h1>Граф</h1> ";
            s += "<svg width = '600' height = '600'>";
            s += "<defs><marker id='triangle' viewBox='0 0 10 10' refX='1' refY='5' markerUnits='strokeWidth' markerWidth='10' markerHeight='10' orient='auto'><path d='M 0 0 L 10 5 L 0 10 z' fill='#f00' /></marker></defs>";
            int cnt = g.Nodes.Count();
            int ecnt = g.Edges.Count();
            int i = 0;
            int j = 0;
           

            while (i < cnt)
            {
                s += $"<circle cx = '{g.Nodes[i].Cx}' cy = '{g.Nodes[i].Cy}' r = '40' stroke = 'green' stroke-width = '4' fill = 'yellow' /> ";
                s += $"<text x = '{g.Nodes[i].Cx-25}' y = '{g.Nodes[i].Cy+5}'> Узел: {g.Nodes[i].Text}</text>";
                
                if (g.Nodes[i].Value.Id == 2 || g.Nodes[i].Value.Id == 5) {
                    s += $"<text x = '{g.Nodes[i].Cx + 50}' y = '{g.Nodes[i].Cy + 5}'>{g.Nodes[i].Value.Name}</text>";
                }
                else
                {
                    s += $"<text x = '{g.Nodes[i].Cx - 140}' y = '{g.Nodes[i].Cy + 5}'>{g.Nodes[i].Value.Name}</text>";
                }
                

                i++;
            }
            while (j < ecnt)
            {
               
                s += $"<line x1='{g.Edges[j].Cx1}' y1='{g.Edges[j].Cy1}' x2='{g.Edges[j].Cx2}' y2='{g.Edges[j].Cy2}' stroke='black' marker-end='url(#triangle)'/>";
                s += $"<text x = '{((g.Edges[j].Cx1 + g.Edges[j].Cx2)/2)+15}' y = '{(g.Edges[j].Cy1 + g.Edges[j].Cy2) / 2}'> {g.Edges[j].Weight}</text>";
                j++;
            }
           
            s += "</svg ></body ></html>";
            System.IO.File.WriteAllText("graph.svg", s);
        }
    }

    class Network
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Node<T>
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public T Value { get; set; }
        public int Cx { get; set; }
        public int Cy { get; set; }
    }

    class Edge<T>
    {
        public float Weight { get; set; }
        public Node<T> NodeFirst { get; set; }
        public Node<T> NodeSecond { get; set; }
        public int Cx1 { get; set; }
        public int Cy1 { get; set; }
        public int Cx2 { get; set; }
        public int Cy2 { get; set; }

    }

    class Graph<T>
    {
        public Graph(List<Node<T>> nodes, List<Edge<T>> edges)
        {
            this.Nodes = nodes;
            this.Edges = edges;
        }
        public List<Node<T>> Nodes { get; set; }
        public List<Edge<T>> Edges { get; set; }
    }
}
