﻿// ************************************************************************
//  
// Copyright © 2010-2018 wuhan wangyou tec.Corporation,All Rights Reserved.
// 版权所有：     武汉网友科技有限公司
//
// 作者(Author):                    毛善丽
//
// 数据表(Table):
//
// 创建日期(Create Time):
//
// 说明（Description):
//
// 修改记录（Revision History)：
//    R1: 
//           
// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateCombine
{
    class PancakeHouseIterator : Iterator
    {
        List<MenuItem> lst;
        int position = 0;
        public PancakeHouseIterator(List<MenuItem> lst)
        {
            this.lst = lst;
        }
        public bool hasNext()
        {
            if ( position >= lst.Count||lst[position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            MenuItem item = lst[position];
            position = position + 1;
            return item;
        }
    }
}