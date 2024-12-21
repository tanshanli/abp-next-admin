// Copyright 2023 The Ip2Region Authors. All rights reserved.
// Use of this source code is governed by a Apache2.0-style
// license that can be found in the LICENSE file.
// @Author Alan <lzh.shap@gmail.com>
// @Date   2023/07/25

using IP2Region.Net.Internal.Abstractions;
using IP2Region.Net.XDB;
using System;
using System.IO;

namespace IP2Region.Net.Internal;

internal class CacheStrategyFactory
{
    private readonly Stream _xdbStream;

    public CacheStrategyFactory(Stream xdbStream)
    {
        _xdbStream = xdbStream;
    }

    public AbstractCacheStrategy CreateCacheStrategy(CachePolicy cachePolicy)
    {
        return cachePolicy switch
        {
            CachePolicy.Content => new ContentCacheStrategy(_xdbStream),
            CachePolicy.VectorIndex => new VectorIndexCacheStrategy(_xdbStream),
            CachePolicy.File => new FileCacheStrategy(_xdbStream),
            _ => throw new ArgumentException(nameof(cachePolicy))
        };
    }
}