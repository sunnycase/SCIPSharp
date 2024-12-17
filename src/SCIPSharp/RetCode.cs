using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scip;

internal enum RetCode : int
{
    /// <summary>
    /// normal termination
    /// </summary>
    Okay = +1,

    /// <summary>
    /// unspecified error
    /// </summary>
    Error = 0,

    /// <summary>
    /// insufficient memory error
    /// </summary>
    NoMemory = -1,

    /// <summary>
    /// read error
    /// </summary>
    ReadError = -2,

    /// <summary>
    /// write error
    /// </summary>
    WriteError = -3,

    /// <summary>
    /// file not found error
    /// </summary>
    NoFile = -4,

    /// <summary>
    /// cannot create file
    /// </summary>
    FileCreateError = -5,

    /// <summary>
    /// error in LP solver
    /// </summary>
    LpError = -6,

    /// <summary>
    /// no problem exists
    /// </summary>
    NoProblem = -7,

    /// <summary>
    /// method cannot be called at this time in solution process
    /// </summary>
    InvalidCall = -8,

    /// <summary>
    /// error in input data
    /// </summary>
    InvalidData = -9,

    /// <summary>
    /// method returned an invalid result code
    /// </summary>
    InvalidResult = -10,

    /// <summary>
    /// a required plugin was not found
    /// </summary>
    PluginNotFound = -11,

    /// <summary>
    /// the parameter with the given name was not found
    /// </summary>
    ParameterUnknown = -12,

    /// <summary>
    /// the parameter is not of the expected type
    /// </summary>
    ParameterWrongType = -13,

    /// <summary>
    /// the value is invalid for the given parameter
    /// </summary>
    ParameterWrongVal = -14,

    /// <summary>
    /// the given key is already existing in table
    /// </summary>
    KeyAlreadyExisting = -15,

    /// <summary>
    /// maximal branching depth level exceeded
    /// </summary>
    MaxDepthLevel = -16,

    /// <summary>
    /// no branching could be created
    /// </summary>
    BranchError = -17,

    /// <summary>
    /// function not implemented
    /// </summary>
    NotImplemented = -18,
}

internal static class RetCodeExtentions
{
    public static void ThrowIfFailed(this RetCode retCode)
    {
        if (retCode != RetCode.Okay)
        {
            throw new InvalidOperationException($"Scip failed with retcode: {retCode}.");
        }
    }
}
