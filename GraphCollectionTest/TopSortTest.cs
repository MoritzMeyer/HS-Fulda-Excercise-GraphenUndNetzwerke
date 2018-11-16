﻿using System;
using System.Collections.Generic;
using GraphCollection;
using GraphCollection.SearchAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphCollectionTest
{
    [TestClass]
    public class TopSortTest
    {
        #region TopSort
        /// <summary>
        /// Testet den TopSort Algorithmus
        /// </summary>
        [TestMethod]
        public void TopSort_must_work()
        {
            Graph<int> graph = new Graph<int>(new List<int>() { 0, 1, 2, 3, 4, 5, 6 });

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(3, 5);
            graph.AddEdge(3, 6);

            SortedList<int, Vertex<int>> topSort = graph.TopSort();

            Assert.AreEqual(7, topSort.Count);
            foreach(KeyValuePair<int, Vertex<int>> v in topSort)
            {
                Assert.AreEqual(v.Key, v.Value.Value);
            }
        }
        #endregion
    }
}