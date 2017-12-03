# ETABSTupleFunc
ETABS API wrapper converting all functions to tuple return types (C# 7.0)

------------------------------------------
Currently the ETABS 2016 C# API passes values using ref parameters, which is painful.
For example, to get the axial force, the following code is required:

    int NumberResults;
    NumberResults = default(int);
    string[] Obj, Elm, LoadCase, StepType;
    Obj = Elm = LoadCase = StepType = default(string[]);
    double[] ObjSta, ElmSta, StepNum, P, V2, V3, T, M2, M3;
    ObjSta = ElmSta = StepNum = P = V2 = V3 = T = M2 = M3 = default(double[]);
    AnalysisResults.FrameForce(Name, ItemTypeElm, ref NumberResults, ref Obj, ref ObjSta, ref Elm, ref ElmSta, ref LoadCase, ref StepType, ref StepNum, ref P, ref V2, ref V3, ref T, ref M2, ref M3);

This library of extension methods simplifies this using ValueTuples and discards (C# 7.0, .NET Framework 4.7)

    (_,_,_,_,_,_,_,_,double P,_,_,_,_,_)=AnalysisResults.FrameForce(Name, ItemTypeElm);

------------------------------------------
CREATE WRAPPER FOR OTHER VERSIONS OF ETABS

Currently, wrappers have been generated only for ETABS2016, 
but can easily by created for other versions of the API (e.g. ETABS2017):
1) References>Add reference>Browse>select ETABS2017.dll
2) Right click on project>Initialize Interactive with Project>
    WrapperGenerator.CreateWrapper("ETABS2017","ETABS2017");
3) Solution Explore>Show All Files
4) Extensions_2017>Include in Project
5) Build project

------------------------------------------
TO USE WRAPPERS IN PLUGIN

To use this library in your plugin:
1) Project>ProjectName Properties>Application>Target Framework>.NET Framework 4.7 (or greater)
2) References>Add reference>Browse>ETABSTupleFunc.dll
3) add to each file: using ETABS2016;
4) Intellisense should now include (extension) overloads for most ETABS functions
