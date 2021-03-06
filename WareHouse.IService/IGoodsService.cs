﻿/*
 * Copyright (c) 2020
 * All rights reserved.
 *
 * 文件名称：IGoodsService.cs
 /* 摘   要：
 *
 * 当前版本：1.0
 * 作   者：SoulCrazy
 * 创建时间：2020-03-23 20:25:58
 */

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WareHouse.Core.Data;
using WareHouse.Entity;

namespace WareHouse.Service.Interface
{
    public interface IGoodsService : IBaseService
    {
        IPageResult<Goods> GetPageResult(IPager pager);

        List<Goods> GetAll();

        List<Goods> GetAll(Expression<Func<Goods, bool>> whereExpression);

        Goods Find(int id);

        int GetId(Goods goods);

        bool Add(Goods goods);

        bool Delete(int id);

        bool Delete(Goods goods);

        bool Update(Goods goods);

        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Out(int id);

        /// <summary>
        /// 在仓库里的
        /// </summary>
        /// <returns></returns>
        List<Goods> Inside();

        /// <summary>
        /// 分页查询在仓库里的
        /// </summary>
        /// <param name="pager"></param>
        /// <returns></returns>
        IPageResult<Goods> InsidePage(IPager pager);

        /// <summary>
        /// 不在仓库的货物
        /// </summary>
        /// <returns></returns>
        List<Goods> Outside();

        /// <summary>
        /// 分页查询不在仓库的货物
        /// </summary>
        /// <param name="pager"></param>
        /// <returns></returns>
        IPageResult<Goods> OutsidePage(IPager pager);
    }
}