﻿using System;

namespace Adapter
{
    public interface IGraph
    {
        void Point(double x, double y);
    }

    class PolarGraph
    {
        public void Point(double r, double t)
        {
            Console.WriteLine("Polar Coordinate Point: P(" + r + ", " + t + ")");
        }
    }
    //Adapter triển khai interface mà client sử dụng.
    class PolarGraphAdapter : IGraph
    {
        private readonly PolarGraph polarGraph;
        public PolarGraphAdapter(PolarGraph polarGraph)
        {
            //Lấy reference đến object cần phải thích ứng.
            this.polarGraph = polarGraph;
        }

        //Implement method Point của interface.
        public void Point(double x, double y)
        {
            //Nhận tung độ và hoành độ x và y, xử lý thành độ dài và góc quay r, t
            double r = Math.Sqrt(x * x + y * y);
            double t = Math.Atan2(y, x);
            //Gọi method Point từ object polarGraph. 
            polarGraph.Point(r, t);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PolarGraph polarGraph = new PolarGraph();
            IGraph graph = new PolarGraphAdapter(polarGraph);
            graph.Point(3, 4);
            //Output: Polar Coordinate Point: P(5, 0.9272952180016122)
        }
    }
}

