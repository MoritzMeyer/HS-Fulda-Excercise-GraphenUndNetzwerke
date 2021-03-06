﻿using System;
using System.Collections.Generic;
using GraphCollection;
using GraphCollection.SearchAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphCollectionTest
{
    [TestClass]
    public class DepthFirstSearchTest
    {
        #region DepthFirstSearch_must_work
        [TestMethod]
        public void DepthFirstSearch_must_work()
        {
            Graph<TwoBuckets> graph = GraphGenerator.BucketGraph(3, 5);

            Assert.IsTrue(graph.DepthFirstSearch(new Vertex<TwoBuckets>(new TwoBuckets(3, 5, 0, 0)), new Vertex<TwoBuckets>(new TwoBuckets(3, 5, 0, 4)), out List<Edge<TwoBuckets>> path));

            Assert.AreEqual(new TwoBuckets(3, 5, 0, 0), path[0].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 0, 5), path[0].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 0, 5), path[1].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 2), path[1].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 2), path[2].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 0), path[2].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 0), path[3].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 0, 3), path[3].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 0, 3), path[4].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 3), path[4].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 3), path[5].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 1, 5), path[5].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 1, 5), path[6].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 1, 0), path[6].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 1, 0), path[7].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 0, 1), path[7].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 0, 1), path[8].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 1), path[8].To.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 3, 1), path[9].From.Value);
            Assert.AreEqual(new TwoBuckets(3, 5, 0, 4), path[9].To.Value);
        }
        #endregion

        #region HasCycle_must_work
        [TestMethod]
        public void HasCycle_must_work()
        {
            Vertex<int> v1 = new Vertex<int>(1);
            Vertex<int> v2 = new Vertex<int>(2);
            Vertex<int> v3 = new Vertex<int>(3);
            Vertex<int> v4 = new Vertex<int>(4);
            Vertex<int> v5 = new Vertex<int>(5);
            Vertex<int> v6 = new Vertex<int>(6);

            Graph<int> graph = new Graph<int>(new List<Vertex<int>>() { v1, v2, v3, v4, v5, v6 });

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(3, 6);

            Assert.IsFalse(graph.HasCycle());

            graph.AddEdge(6, 5);

            Assert.IsTrue(graph.HasCycle());

        }
        #endregion
    }
}
