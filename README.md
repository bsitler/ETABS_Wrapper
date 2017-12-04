# Welcome to ETABS_Wrapper
C# wrapper for the [CSI ETABS API](https://www.csiamerica.com/application-programming-interface), converting all functions to tuple return types

## Example Usage
Currently the ETABS 2016 C# API passes values using ref parameters, which is painful.
For example, to get the axial force, the following code is required:

    'int NumberResults;
    NumberResults = default(int);
    string[] Obj, Elm, LoadCase, StepType;
    Obj = Elm = LoadCase = StepType = default(string[]);
    double[] ObjSta, ElmSta, StepNum, P, V2, V3, T, M2, M3;
    ObjSta = ElmSta = StepNum = P = V2 = V3 = T = M2 = M3 = default(double[]);
    AnalysisResults.FrameForce(Name, ItemTypeElm, ref NumberResults,
								ref Obj, ref ObjSta, ref Elm, ref ElmSta,
								ref LoadCase, ref StepType, ref StepNum,
								ref P, ref V2, ref V3, ref T, ref M2, ref M3);'

This library of extension methods simplifies this using ValueTuples and discards (C# 7.0, .NET Framework 4.7)

    '(_,_,_,_,_,_,_,_,double P,_,_,_,_,_)=AnalysisResults.FrameForce(Name, ItemTypeElm);'

    or
	
	'var results = AnalysisResults.FrameForce(Name, ItemTypeElm);
	double P = results.P;'
	
	or
	
	'double P = AnalysisResults.FrameForce(Name, ItemTypeElm).P;'

## Use extensions in your plugin

To use this library in your plugin:
* Project>ProjectName Properties>Application>Target Framework>.NET Framework 4.7 (or greater)
* References>Add reference>Browse>ETABS2016_Extensions.dll
* Intellisense should now include (extension) overloads for most ETABS functions

## Create wrapper for other versions of ETABS API

Currently, wrappers have been generated only for ETABS2016, 
but can easily by created for other versions of the API (e.g. ETABS2017):
In ETABS_Wrapper project
* References>Add reference>Browse>select ETABS2017.dll
* Right click on project>Initialize Interactive with Project>
    WrapperGenerator.CreateWrapper("ETABS2017","ETABS2017");
<<<<<<< HEAD
* Solution>Add>New Project>ETABS2017_Extensions
In new project
* Copy Extensions_2017 folder and new wrapper classes to new project
* Solution Explore>Show All Files
* Select folder Extensions_2017>Include in Project
* References>Add reference>Browse>select ETABS2017.dll
* Build project
=======
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
>>>>>>> b7559c680900b3bbd27d824b66e85ff92637cfee
