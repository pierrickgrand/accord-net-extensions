﻿using System;
using Accord.Imaging.Filters;

namespace Accord.Extensions.Imaging.Filters
{
    static class GrayWorldExtensionsBase
    {
        /// <summary>
        /// Gray World filter for color normalization. 
        /// <para>Accord.NET internal call.</para>
        /// </summary>
        /// <param name="img">Image.</param>
        /// <param name="inPlace">Apply in place or not. If it is set to true return value can be omitted.</param>
        /// <returns>Processed image.</returns>
        internal static Image<TColor, TDepth> GrayWorld<TColor, TDepth>(this Image<TColor, TDepth> img, bool inPlace = true)
            where TColor : IColor
            where TDepth : struct
        {
            GrayWorld gw = new GrayWorld();
            return img.ApplyFilter(gw, inPlace);
        }
    }

    /// <summary>
    /// Contains extensions for Gray-world algorithm.
    /// </summary>
    public static class GrayWorldExtensionsIColor3
    {
        /// <summary>
        /// Gray World filter for color normalization. 
        /// <para>Accord.NET internal call.</para>
        /// </summary>
        /// <param name="img">Image.</param>
        /// <param name="inPlace">Apply in place or not. If it is set to true return value can be omitted.</param>
        /// <returns>Processed image.</returns>
        public static Image<Bgr, byte> GrayWorld(this Image<Bgr, byte> img, bool inPlace = true)
        {
            return GrayWorldExtensionsBase.GrayWorld<Bgr, byte>(img, inPlace);
        }
    }

    /// <summary>
    /// Contains extensions for Gray-world algorithm.
    /// </summary>
    public static class GrayWorldExtensionsIColor4
    {
        /// <summary>
        /// Gray World filter for color normalization. 
        /// <para>Accord.NET internal call.</para>
        /// </summary>
        /// <param name="img">Image.</param>
        /// <param name="inPlace">Apply in place or not. If it is set to true return value can be omitted.</param>
        /// <returns>Processed image.</returns>
        public static Image<Bgra, byte> GrayWorld(this Image<Bgra, byte> img, bool inPlace = true)
        {
            return GrayWorldExtensionsBase.GrayWorld<Bgra, byte>(img, inPlace);
        }
    }
}