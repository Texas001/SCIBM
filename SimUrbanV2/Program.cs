using System;
using System.Collections.Generic;
using SimUrbanV2.Agents;
using SimUrbanV2.Initialize;

namespace SimUrbanV2
{
    class Program
    {
        static void Main(string[] args)
        {

            //测试功能
            //SyntheticPop test = new SyntheticPop();
            //test.test();
            Geoenvironment test2 = new Geoenvironment();
            //string block_jsonfile = @"D:\Paper2022\城市疫情模拟与医疗资源布局优化\SimUrbanV2\bin\Debug\netcoreapp3.1\test.json";
            List<Block> resultlist = new List<Block>();
            List<double> randomlist = new List<double>();
            //test2.ini(ref block_jsonfile, ref resultlist);

            //Initializing blocks with synthetic population
            Geoenvironment geoenvironment = new Geoenvironment();
            SyntheticPop syntheticPop = new SyntheticPop();
            string block_jsonfile = @"D:\Paper2022\城市疫情模拟与医疗资源布局优化\SimUrbanV2\bin\Debug\netcoreapp3.1\test.json";
            List<Block> blocks_RawList = new List<Block>();
            geoenvironment.Iniblocks(ref block_jsonfile, ref blocks_RawList);
            string pop_jsonfile = @"D:\Paper2022\城市疫情模拟与医疗资源布局优化\SimUrbanV2\bin\Debug\netcoreapp3.1\test.json";
            List<Person> pop_RawList = new List<Person>();
            syntheticPop.IniPop(ref pop_jsonfile,ref pop_RawList);

            //Initialize model parameters
            Paras paras = new Paras();
            Parameters_COVID19 par_COVID19 = new Parameters_COVID19();
            Parameters_ModelBasic par_ModelBasic = new Parameters_ModelBasic();
            paras.Parameters_Ini();
            
        }
    }
}
