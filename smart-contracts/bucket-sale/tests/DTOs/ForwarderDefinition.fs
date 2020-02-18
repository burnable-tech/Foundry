namespace Foundry.Contracts.Forwarder.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.Web3
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts
open System.Threading

    
    
    type ForwarderDeployment(byteCode: string) =
        inherit ContractDeploymentMessage(byteCode)
        
        static let BYTECODE = "0x608060405234801561001057600080fd5b506103ee806100206000396000f3fe60806040526004361061003b576000357c0100000000000000000000000000000000000000000000000000000000900480636fadcf7214610040575b600080fd5b6101196004803603604081101561005657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019064010000000081111561009357600080fd5b8201836020820111156100a557600080fd5b803590602001918460018302840111640100000000831117156100c757600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f82011690508083019250505050505050919291929050505061019f565b604051808315151515815260200180602001828103825283818151815260200191508051906020019080838360005b83811015610163578082015181840152602081019050610148565b50505050905090810190601f1680156101905780820380516001836020036101000a031916815260200191505b50935050505060405180910390f35b60006060600060608573ffffffffffffffffffffffffffffffffffffffff1634866040518082805190602001908083835b602083106101f357805182526020820191506020810190506020830392506101d0565b6001836020036101000a03801982511681845116808217855250505050505090500191505060006040518083038185875af1925050503d8060008114610255576040519150601f19603f3d011682016040523d82523d6000602084013e61025a565b606091505b50915091508573ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff167f0c991d70033760b32e5748ac2414f25b432c49b28384ae56735d92f79468e1f68734868660405180806020018581526020018415151515815260200180602001838103835287818151815260200191508051906020019080838360005b838110156103065780820151818401526020810190506102eb565b50505050905090810190601f1680156103335780820380516001836020036101000a031916815260200191505b50838103825284818151815260200191508051906020019080838360005b8381101561036c578082015181840152602081019050610351565b50505050905090810190601f1680156103995780820380516001836020036101000a031916815260200191505b50965050505050505060405180910390a38181935093505050925092905056fea265627a7a72315820faf252dd02d208f44ddccebb57dc3cb28a2b894d6bc1efb453f23441be32c73864736f6c63430005100032"
        
        new() = ForwarderDeployment(BYTECODE)
        

    [<FunctionOutput>]
    type ForwardOutputDTO() =
        inherit FunctionOuputDTO() 
            [<Parameter("bool", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<bool> with get, set
            [<Parameter("bytes", "", 2)>]
            member val public ReturnValue2 = Unchecked.defaultof<byte[]> with get, set
    
                
    [<Function("forward", typeof<ForwardOutputDTO>)>]
    type ForwardFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "_to", 1)>]
            member val public To = Unchecked.defaultof<string> with get, set
            [<Parameter("bytes", "_data", 2)>]
            member val public Data = Unchecked.defaultof<byte[]> with get, set
        
    
    [<Event("Forwarded")>]
    type ForwardedEventDTO() =
        inherit EventDTO()
            [<Parameter("address", "_msgSender", 1, true )>]
            member val MsgSender = Unchecked.defaultof<string> with get, set
            [<Parameter("address", "_to", 2, true )>]
            member val To = Unchecked.defaultof<string> with get, set
            [<Parameter("bytes", "_data", 3, false )>]
            member val Data = Unchecked.defaultof<byte[]> with get, set
            [<Parameter("uint256", "_wei", 4, false )>]
            member val Wei = Unchecked.defaultof<BigInteger> with get, set
            [<Parameter("bool", "_success", 5, false )>]
            member val Success = Unchecked.defaultof<bool> with get, set
            [<Parameter("bytes", "_resultData", 6, false )>]
            member val ResultData = Unchecked.defaultof<byte[]> with get, set
        
    

    

