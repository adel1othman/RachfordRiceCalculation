//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class GuessesStructure : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GuessesStructure(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GuessesStructure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GuessesStructure() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CoolPropPINVOKE.delete_GuessesStructure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double T {
    set {
      CoolPropPINVOKE.GuessesStructure_T_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CoolPropPINVOKE.GuessesStructure_T_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double p {
    set {
      CoolPropPINVOKE.GuessesStructure_p_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CoolPropPINVOKE.GuessesStructure_p_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double rhomolar {
    set {
      CoolPropPINVOKE.GuessesStructure_rhomolar_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CoolPropPINVOKE.GuessesStructure_rhomolar_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double hmolar {
    set {
      CoolPropPINVOKE.GuessesStructure_hmolar_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CoolPropPINVOKE.GuessesStructure_hmolar_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double smolar {
    set {
      CoolPropPINVOKE.GuessesStructure_smolar_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CoolPropPINVOKE.GuessesStructure_smolar_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double rhomolar_liq {
    set {
      CoolPropPINVOKE.GuessesStructure_rhomolar_liq_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CoolPropPINVOKE.GuessesStructure_rhomolar_liq_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double rhomolar_vap {
    set {
      CoolPropPINVOKE.GuessesStructure_rhomolar_vap_set(swigCPtr, value);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CoolPropPINVOKE.GuessesStructure_rhomolar_vap_get(swigCPtr);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector x {
    set {
      CoolPropPINVOKE.GuessesStructure_x_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.GuessesStructure_x_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DoubleVector y {
    set {
      CoolPropPINVOKE.GuessesStructure_y_set(swigCPtr, DoubleVector.getCPtr(value));
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CoolPropPINVOKE.GuessesStructure_y_get(swigCPtr);
      DoubleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleVector(cPtr, false);
      if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public GuessesStructure() : this(CoolPropPINVOKE.new_GuessesStructure(), true) {
    if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
  }

}
