﻿using java.util;
using System;

/*
  Licensed under the Apache License, Version 2.0
    http://www.apache.org/licenses/LICENSE-2.0.html

  AUTOGENERATED BY H2O at 2017-05-13T11:09:00.782-04:00
  3.10.4.4
  
  Standalone prediction code with sample test data for GBMModel named grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1

  How to download, compile and execute:
      mkdir tmpdir
      cd tmpdir
      curl http://127.0.0.1:54321/3/h2o-genmodel.jar > h2o-genmodel.jar
      curl http://127.0.0.1:54321/3/Models.java/grid-f6497669-4fd1-4bd0-b8b3-9ad79c496aa2_model_1 > grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1.java
      javac -cp h2o-genmodel.jar -J-Xmx2g -J-XX:MaxPermSize=128m grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1.java

     (Note:  Try java argument -XX:+PrintCompilation to show runtime JIT compiler behavior.)
*/
using GenModel = hex.genmodel.GenModel;
using ModelPojo = hex.genmodel.annotations.ModelPojo;
using IKVM.Attributes;
using java.lang.annotation;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ModelPojo(name="grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1", algorithm="gbm") public class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1 extends hex.genmodel.GenModel

public class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1 : GenModel
{
  public override hex.ModelCategory getModelCategory()
  {
	    return hex.ModelCategory.Binomial;
  }

  public virtual bool Supervised
  {
	  get
	  {
		  return true;
	  }
  }
  public virtual int nfeatures()
  {
	  return 13;
  }
  public virtual int nclasses()
  {
	  return 2;
  }

  // Names of columns used by model.
  public static readonly string[] NAMES = NamesHolder_grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1.VALUES;
  // Number of output classes included in training data response column.
  public const int NCLASSES = 2;

  // Column domains. The last array contains domain of response column.
  public static readonly string[][] DOMAINS = new string[][] {null, null, null, null, null, null, null, null, null, null, null, null, null, grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_ColInfo_13.VALUES};
  // Prior class distribution
  public static readonly double[] PRIOR_CLASS_DISTRIB = new double[] {0.5065312046444121,0.4934687953555878};
  // Class distribution used for model building
  public static readonly double[] MODEL_CLASS_DISTRIB = new double[] {0.5065312046444121,0.4934687953555878};

  public grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1() : base(NAMES,DOMAINS)
  {
  }
  public override string getUUID()
  {
	    return Convert.ToString(362333225048714520L);
  }

  // Pass in data in a double[], pre-aligned to the Model's requirements.
  // Jam predictions into the preds[] array; preds[0] is reserved for the
  // main prediction (class for classifiers or value for regression),
  // and remaining columns hold a probability distribution for classifiers.
  public override double[] score0(double[] data, double[] preds)
  {
	Arrays.fill(preds,0);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_0.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_1.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_2.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_3.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_4.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_5.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_6.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_7.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_8.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_9.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_10.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_11.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_12.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_13.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_14.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_15.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_16.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_17.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_18.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_19.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_20.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_21.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_22.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_23.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_24.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_25.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_26.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_27.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_28.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_29.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_30.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_31.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_32.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_33.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_34.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_35.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_36.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_37.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_38.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_39.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_40.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_41.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_42.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_43.score0(data,preds);
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_44.score0(data,preds);
	//grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_45.score0(data,preds);
	//grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_46.score0(data,preds);
	//grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_47.score0(data,preds);
	//grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_48.score0(data,preds);
	//grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_49.score0(data,preds);
	preds[2] = preds[1] + -0.026126304592220036;
	preds[2] = 1.0 / (1.0 + Math.Min(1e19, Math.Exp(-(preds[2]))));
	preds[1] = 1.0 - preds[2];
	preds[0] = GenModel.getPrediction(preds, PRIOR_CLASS_DISTRIB, data, 0.41709106734685203);
	return preds;
  }
}
// The class representing training column names
[Serializable]
internal class NamesHolder_grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1
{
  public static readonly string[] VALUES = new string[13];
  static NamesHolder_grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1()
  {
	NamesHolder_grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_0.fill(VALUES);
  }
  [Serializable]
  internal sealed class NamesHolder_grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_0
  {
	internal static void fill(string[] sa)
	{
	  sa[0] = "t_games";
	  sa[1] = "win_rate";
	  sa[2] = "avg_points";
	  sa[3] = "fgr";
	  sa[4] = "fg3r";
	  sa[5] = "ftr";
	  sa[6] = "orr";
	  sa[7] = "drr";
	  sa[8] = "astr";
	  sa[9] = "tor";
	  sa[10] = "stlr";
	  sa[11] = "blkr";
	  sa[12] = "pfr";
	}
  }
}
// The class representing column win_flag
[Serializable]
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_ColInfo_13
{
  public static readonly string[] VALUES = new string[2];
  static grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_ColInfo_13()
  {
	grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_ColInfo_13_0.fill(VALUES);
  }
  [Serializable]
  internal sealed class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_ColInfo_13_0
  {
	internal static void fill(string[] sa)
	{
	  sa[0] = "0";
	  sa[1] = "1";
	}
  }
}

internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_0
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_0_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_0_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.09780078f ? (data[0] < -2.5f ? -0.13210393f : -0.018031169f) : (data[11] < -0.97905105f ? 0.013141035f : 0.119515985f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_1
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_1_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_1_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.008262943f ? (data[6] < -3.1554103f ? -0.19210598f : -0.04409598f) : (double.IsNaN(data[12]) || data[12] < 2.6376061f ? 0.07542666f : -0.054183315f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_2
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_2_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_2_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[2] < -0.16806696f ? (data[0] < -0.5f ? -0.121262096f : -8.182073E-4f) : (double.IsNaN(data[1]) || data[1] < 0.18843724f ? 0.012061213f : 0.17538984f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_3
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_3_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_3_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[2] < -0.16806696f ? (data[2] < -9.46659f ? -0.121315174f : -0.02556684f) : (double.IsNaN(data[9]) || data[9] < 2.1607022f ? 0.042280927f : -0.05744228f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_4
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_4_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_4_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.09780078f ? (double.IsNaN(data[6]) || data[6] < 0.225509f ? -0.049309205f : 0.022045162f) : (data[3] < 0.02431972f ? 0.04097641f : 0.12805931f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_5
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_5_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_5_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[0] < -0.5f ? (double.IsNaN(data[8]) || data[8] < 1.446306f ? -0.08709996f : 0.0110432645f) : (double.IsNaN(data[11]) || data[11] < 0.9299712f ? -7.113336E-4f : 0.100537956f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_6
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_6_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_6_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[2] < -4.1258774f ? (data[3] < -0.02363299f ? -0.1311006f : -0.023658969f) : (double.IsNaN(data[0]) || data[0] < 0.5f ? -0.015314044f : 0.08177826f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_7
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_7_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_7_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.023643676f ? (data[1] < -0.23106323f ? -0.1266852f : -0.018261116f) : (double.IsNaN(data[1]) || data[1] < 0.21880174f ? 0.027332908f : 0.1593286f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_8
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_8_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_8_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[11]) || data[11] < 0.9299712f ? (double.IsNaN(data[1]) || data[1] < 0.008262943f ? -0.056549568f : 0.027972851f) : (double.IsNaN(data[1]) || data[1] < 0.14559092f ? 0.010903386f : 0.14107558f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_9
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_9_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_9_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[0] < -0.5f ? (double.IsNaN(data[2]) || data[2] < 0.68003523f ? -0.076074384f : 0.014243124f) : (double.IsNaN(data[12]) || data[12] < 2.9478247f ? 0.04563612f : -0.0872784f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_10
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_10_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_10_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.05110927f ? (double.IsNaN(data[5]) || data[5] < 0.054153763f ? -0.04546986f : 0.052571997f) : (double.IsNaN(data[12]) || data[12] < 3.0216863f ? 0.07068142f : -0.1196456f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_11
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_11_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_11_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[0] < -0.5f ? (data[3] < -0.019167759f ? -0.15283231f : -0.03278401f) : (data[7] < -3.3179138f ? -0.064962976f : 0.03396076f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_12
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_12_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_12_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[0]) || data[0] < 0.5f ? (double.IsNaN(data[9]) || data[9] < 2.7860804f ? -0.0012061878f : -0.112766154f) : (double.IsNaN(data[6]) || data[6] < 0.32593235f ? -0.017822674f : 0.103514105f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_13
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_13_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_13_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.09780078f ? (data[3] < -3.3612738E-4f ? -0.05622871f : 0.013075863f) : (data[12] < -2.1190805f ? 0.12323167f : 0.01712151f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_14
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_14_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_14_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[11]) || data[11] < 1.2856897f ? (double.IsNaN(data[0]) || data[0] < 3.5f ? -0.01315251f : 0.102538794f) : (data[1] < -0.04556962f ? -0.037355766f : 0.07531571f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_15
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_15_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_15_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[12]) || data[12] < 4.4693737f ? (data[6] < -0.8456734f ? -0.04200372f : 0.03434315f) : -0.14456712f);
	return pred;
  } // constant pool size = 10B, number of visited nodes = 2, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_16
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_16_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_16_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[12] < -2.5327055f ? (data[1] < 0.013756061f ? -0.024108367f : 0.09501276f) : (double.IsNaN(data[11]) || data[11] < 1.2264032f ? -0.04126235f : 0.03347713f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_17
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_17_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_17_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[9] < -2.3360636f ? (double.IsNaN(data[5]) || data[5] < 0.071420416f ? 0.12094695f : -0.031992096f) : (double.IsNaN(data[9]) || data[9] < 1.208385f ? 0.012022682f : -0.047122825f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_18
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_18_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_18_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[12]) || data[12] < 4.4693737f ? (data[9] < -2.797652f ? 0.08214774f : -0.009296676f) : -0.11805399f);
	return pred;
  } // constant pool size = 10B, number of visited nodes = 2, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_19
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_19_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_19_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[12]) || data[12] < 4.4693737f ? (data[2] < -2.1034796f ? -0.030738594f : 0.029449807f) : -0.15245494f);
	return pred;
  } // constant pool size = 10B, number of visited nodes = 2, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_20
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_20_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_20_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[9] < -2.827432f ? (data[8] < -0.575983f ? 0.040382434f : 0.14444895f) : (double.IsNaN(data[6]) || data[6] < 0.45983014f ? -0.031091183f : 0.027428491f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_21
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_21_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_21_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.09780078f ? (data[9] < -2.827432f ? 0.10928006f : -0.020098131f) : (data[0] < 0.5f ? -0.029933454f : 0.10751243f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_22
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_22_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_22_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[11]) || data[11] < 0.9299712f ? (data[1] < -0.015906781f ? -0.04351061f : 0.01962518f) : (double.IsNaN(data[12]) || data[12] < 0.55470914f ? -0.0066615655f : 0.0795683f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_23
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_23_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_23_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.18843724f ? (double.IsNaN(data[1]) || data[1] < 0.008674926f ? -0.017479194f : 0.039529722f) : (data[9] < -2.484963f ? 0.060149066f : 0.11814334f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_24
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_24_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_24_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[12]) || data[12] < 4.7722063f ? (data[0] < -0.5f ? -0.032636315f : 0.028065024f) : -0.1444491f);
	return pred;
  } // constant pool size = 10B, number of visited nodes = 2, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_25
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_25_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_25_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[1] < -0.1971797f ? (data[9] < 0.09099882f ? -0.05473061f : -0.145707f) : (double.IsNaN(data[9]) || data[9] < 1.6842238f ? 0.018609045f : -0.047987558f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_26
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_26_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_26_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[11]) || data[11] < 0.9299712f ? (double.IsNaN(data[12]) || data[12] < 2.4307938f ? 0.0032533996f : -0.08075676f) : (data[8] < -1.8081061f ? 0.11871389f : 0.013509837f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_27
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_27_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_27_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[2] < -8.627343f ? (double.IsNaN(data[10]) || data[10] < -0.5562184f ? -0.057964854f : -0.15558848f) : (data[0] < -1.5f ? -0.039311856f : 0.015843332f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_28
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_28_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_28_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[12] < -2.5327055f ? (double.IsNaN(data[12]) || data[12] < -2.9914553f ? 0.009303311f : 0.13476147f) : (data[6] < -1.0465201f ? -0.043150593f : 0.018701006f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_29
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_29_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_29_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[6] < -0.8456734f ? (double.IsNaN(data[7]) || data[7] < 2.6141515f ? 0.0053471667f : -0.13797915f) : (double.IsNaN(data[10]) || data[10] < 3.3944132f ? 0.013006982f : 0.13324577f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_30
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_30_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_30_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[9] < -2.3360636f ? (double.IsNaN(data[6]) || data[6] < -0.8456734f ? 0.002840014f : 0.122452155f) : (double.IsNaN(data[5]) || data[5] < 0.08282874f ? -0.014334358f : 0.14978719f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_31
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_31_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_31_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[11]) || data[11] < 1.2856897f ? (data[4] < -0.021946106f ? 0.04325501f : -0.018670006f) : (data[6] < 1.263217f ? 0.06333383f : -0.018976726f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_32
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_32_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_32_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.18843724f ? (data[3] < -7.244084E-4f ? -0.03718522f : 0.031937573f) : (data[5] < -0.016762845f ? 0.0336405f : 0.13132039f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_33
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_33_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_33_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[1]) || data[1] < 0.21810009f ? (data[6] < -0.8456734f ? -0.045711223f : 0.0016012318f) : (data[0] < 1.5f ? 0.13129215f : 0.11632217f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_34
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_34_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_34_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[12] < -2.5327055f ? (data[12] < -4.019055f ? 0.10293969f : 0.026865527f) : (double.IsNaN(data[10]) || data[10] < 0.82355446f ? -0.030995496f : 0.02247003f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_35
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_35_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_35_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[12]) || data[12] < 4.7722063f ? (data[12] < -2.670756f ? 0.052994505f : -0.010753524f) : -0.13977459f);
	return pred;
  } // constant pool size = 10B, number of visited nodes = 2, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_36
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_36_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_36_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[11]) || data[11] < 1.2856897f ? (data[12] < -1.9122682f ? 0.03817205f : -0.033276312f) : (data[12] < -0.52367014f ? -0.02602667f : 0.043294054f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_37
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_37_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_37_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[10]) || data[10] < 3.4297922f ? (data[3] < -0.0275158f ? -0.06160145f : 0.003690752f) : 0.11394799f);
	return pred;
  } // constant pool size = 10B, number of visited nodes = 2, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_38
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_38_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_38_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[0] < -0.5f ? (double.IsNaN(data[10]) || data[10] < -0.037329424f ? -0.0545905f : 0.008705515f) : (data[3] < -0.0030540947f ? -0.018450493f : 0.036006175f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_39
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_39_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_39_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[6] < -0.8456734f ? (double.IsNaN(data[5]) || data[5] < 0.03688711f ? -0.07368318f : 0.034904342f) : (data[9] < -2.484963f ? 0.16693869f : -0.0050314846f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_40
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_40_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_40_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[12]) || data[12] < 4.7722063f ? (double.IsNaN(data[4]) || data[4] < 0.04088802f ? -0.0030479357f : 0.05364347f) : -0.1268026f);
	return pred;
  } // constant pool size = 10B, number of visited nodes = 2, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_41
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_41_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_41_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[1] < -0.23068772f ? (double.IsNaN(data[2]) || data[2] < -4.3650856f ? -0.13069369f : -0.037393887f) : (double.IsNaN(data[12]) || data[12] < 2.4307938f ? 0.009589469f : -0.054620277f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_42
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_42_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_42_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (double.IsNaN(data[11]) || data[11] < 0.9299712f ? (double.IsNaN(data[3]) || data[3] < 0.034026746f ? -0.019540053f : 0.047261f) : (data[5] < -0.06023781f ? 0.12056158f : 0.004363992f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_43
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_43_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_43_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[6] < -0.8456734f ? (double.IsNaN(data[9]) || data[9] < 1.5353242f ? -0.026135987f : -0.12640072f) : (double.IsNaN(data[12]) || data[12] < 2.4751105f ? 0.030797442f : -0.05463627f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}


internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Forest_44
{
  public static void score0(double[] fdata, double[] preds)
  {
	preds[1] += grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_44_class_0.score0(fdata);
  }
}
internal class grid_f6497669_4fd1_4bd0_b8b3_9ad79c496aa2_model_1_Tree_44_class_0
{
  internal static double score0(double[] data)
  {
	double pred = (data[9] < -2.827432f ? (double.IsNaN(data[9]) || data[9] < -3.2385778f ? -0.04857279f : 0.17825505f) : (double.IsNaN(data[5]) || data[5] < 0.0936204f ? -0.01023444f : 0.1707866f));
	return pred;
  } // constant pool size = 14B, number of visited nodes = 3, static init size = 0B
}