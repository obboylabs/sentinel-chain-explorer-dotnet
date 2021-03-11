﻿using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentinelChain.Neth.WhiteList.ContractDefinition
{
    public class WhiteListDeployment : ContractDeploymentMessage
    {
        //public static string BYTECODE = "608060405234801561001057600080fd5b50604051602080610ccb833981016040525160018054600160a060020a03191633179055600160a060020a03811615156100ab57604080517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152601960248201527f4f776e6572206164647265737320697320726571756972656400000000000000604482015290519081900360640190fd5b60018054600160a060020a031916600160a060020a0392909216919091179055610bf1806100da6000396000f3006080604052600436106100b95763ffffffff7c010000000000000000000000000000000000000000000000000000000060003504166306661abd81146100be5780630988ca8c146100e5578063217fe6c61461014e5780633628731c146101c95780633af32abf146101e9578063715018a61461020a5780638da5cb5b1461021f5780639870d7fe1461025057806398a1b39714610271578063a84eb999146102fb578063ac8a584a1461031b578063f2fde38b1461033c575b600080fd5b3480156100ca57600080fd5b506100d361035d565b60408051918252519081900360200190f35b3480156100f157600080fd5b5060408051602060046024803582810135601f810185900485028601850190965285855261014c958335600160a060020a03169536956044949193909101919081908401838280828437509497506103639650505050505050565b005b34801561015a57600080fd5b5060408051602060046024803582810135601f81018590048502860185019096528585526101b5958335600160a060020a03169536956044949193909101919081908401838280828437509497506103d19650505050505050565b604080519115158252519081900360200190f35b3480156101d557600080fd5b5061014c6004803560248101910135610444565b3480156101f557600080fd5b506101b5600160a060020a03600435166105d6565b34801561021657600080fd5b5061014c6105e7565b34801561022b57600080fd5b50610234610655565b60408051600160a060020a039092168252519081900360200190f35b34801561025c57600080fd5b5061014c600160a060020a0360043516610664565b34801561027d57600080fd5b506102866106ab565b6040805160208082528351818301528351919283929083019185019080838360005b838110156102c05781810151838201526020016102a8565b50505050905090810190601f1680156102ed5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b34801561030757600080fd5b5061014c60048035602481019101356106d0565b34801561032757600080fd5b5061014c600160a060020a0360043516610847565b34801561034857600080fd5b5061014c600160a060020a036004351661088b565b60025481565b6103cd826000836040518082805190602001908083835b602083106103995780518252601f19909201916020918201910161037a565b51815160209384036101000a60001901801990921691161790529201948552506040519384900301909220929150506108ab565b5050565b600061043d836000846040518082805190602001908083835b602083106104095780518252601f1990920191602091820191016103ea565b51815160209384036101000a60001901801990921691161790529201948552506040519384900301909220929150506108c0565b9392505050565b600154600090600160a060020a031633146104865761048633604080519081016040528060088152602001600080516020610ba6833981519152815250610363565b600082116104f557604080517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152601860248201527f41646472657373206c6973742069732072657175697265640000000000000000604482015290519081900360640190fd5b5060005b818110156105d15761052583838381811061051057fe5b90506020020135600160a060020a03166108df565b15156105c95760016003600085858581811061053d57fe5b60209081029290920135600160a060020a0316835250810191909152604001600020805460ff191691151591909117905560028054600101905582828281811061058357fe5b90506020020135600160a060020a0316600160a060020a03167f8903e080b5c69a152a91cd02601be1ae6016a2e837de3a938084856cfacbbbfa60405160405180910390a25b6001016104f9565b505050565b60006105e1826108df565b92915050565b600154600160a060020a031633146105fe57600080fd5b600154604051600160a060020a03909116907ff8df31144d9c2f0f6b59d69b8b98abd5459d07f2742c4df920b25aae33c6482090600090a26001805473ffffffffffffffffffffffffffffffffffffffff19169055565b600154600160a060020a031681565b600154600160a060020a0316331461067b57600080fd5b6106a881604080519081016040528060088152602001600080516020610ba68339815191528152506108fd565b50565b6040805180820190915260088152600080516020610ba6833981519152602082015281565b600154600090600160a060020a031633146107125761071233604080519081016040528060088152602001600080516020610ba6833981519152815250610363565b6000821161078157604080517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152601860248201527f41646472657373206c6973742069732072657175697265640000000000000000604482015290519081900360640190fd5b5060005b818110156105d15761079c83838381811061051057fe5b1561083f5760006003818585858181106107b257fe5b60209081029290920135600160a060020a0316835250810191909152604001600020805460ff1916911515919091179055600280546000190190558282828181106107f957fe5b90506020020135600160a060020a0316600160a060020a03167fad800f2ee8cfb758bc00df7311ccf1b8785bef2e53c46a7b0e65e75b29a5b24260405160405180910390a25b600101610785565b600154600160a060020a0316331461085e57600080fd5b6106a881604080519081016040528060088152602001600080516020610ba6833981519152815250610a0e565b600154600160a060020a031633146108a257600080fd5b6106a881610ae0565b6108b582826108c0565b15156103cd57600080fd5b600160a060020a03166000908152602091909152604090205460ff1690565b600160a060020a031660009081526003602052604090205460ff1690565b610967826000836040518082805190602001908083835b602083106109335780518252601f199092019160209182019101610914565b51815160209384036101000a6000190180199092169116179052920194855250604051938490030190922092915050610b5e565b81600160a060020a03167fbfec83d64eaa953f2708271a023ab9ee82057f8f3578d548c1a4ba0b5b700489826040518080602001828103825283818151815260200191508051906020019080838360005b838110156109d05781810151838201526020016109b8565b50505050905090810190601f1680156109fd5780820380516001836020036101000a031916815260200191505b509250505060405180910390a25050565b610a78826000836040518082805190602001908083835b60208310610a445780518252601f199092019160209182019101610a25565b51815160209384036101000a6000190180199092169116179052920194855250604051938490030190922092915050610b83565b81600160a060020a03167fd211483f91fc6eff862467f8de606587a30c8fc9981056f051b897a418df803a82604051808060200182810382528381815181526020019150805190602001908083836000838110156109d05781810151838201526020016109b8565b600160a060020a0381161515610af557600080fd5b600154604051600160a060020a038084169216907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a36001805473ffffffffffffffffffffffffffffffffffffffff1916600160a060020a0392909216919091179055565b600160a060020a0316600090815260209190915260409020805460ff19166001179055565b600160a060020a0316600090815260209190915260409020805460ff1916905556006f70657261746f72000000000000000000000000000000000000000000000000a165627a7a72305820bcfcc79e72c21edb1bc01f4199dab4eb89beb092397741e55423ebe8b1cdad3e0029"; 
        
        
        public static string BYTECODE = "6080604052600060045534801561001557600080fd5b50604051611e8e380380611e8e8339818101604052606081101561003857600080fd5b81019080805190602001909291908051906020019092919080519060200190929190505050600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff161415610100576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601e8152602001807f4e6577206f7261636c652061646472657373206973207265717569726564000081525060200191505060405180910390fd5b600082141561015a576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401808060200182810382526021815260200180611e6d6021913960400191505060405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614156101fd576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260198152602001807f546f6b656e20616464726573732069732072657175697265640000000000000081525060200191505060405180910390fd5b33600360006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555082600260006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555081600181905550806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550505050611b95806102d86000396000f3fe608060405234801561001057600080fd5b50600436106100bb576000357c010000000000000000000000000000000000000000000000000000000090048063a4c0ed3611610083578063a4c0ed361461026c578063bbc9d3e014610367578063d183ce1414610395578063d62457f6146104e5578063fc0c546a14610503576100bb565b806328b50f57146100c05780632e1a7d4d146101925780637adbf973146101c05780637dc0d1d0146102045780638da5cb5b14610238575b600080fd5b610190600480360360608110156100d657600080fd5b8101908080359060200190929190803560ff1690602001909291908035906020019064010000000081111561010a57600080fd5b82018360208201111561011c57600080fd5b8035906020019184600183028401116401000000008311171561013e57600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f820116905080830192505050505050509192919290505050610537565b005b6101be600480360360208110156101a857600080fd5b8101908080359060200190929190505050610c53565b005b610202600480360360208110156101d657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611003565b005b61020c611240565b604051808273ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610240611266565b604051808273ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61034f6004803603606081101561028257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190803590602001906401000000008111156102c957600080fd5b8201836020820111156102db57600080fd5b803590602001918460018302840111640100000000831117156102fd57600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f82011690508083019250505050505050919291929050505061128c565b60405180821515815260200191505060405180910390f35b6103936004803603602081101561037d57600080fd5b810190808035906020019092919050505061160f565b005b6103c1600480360360208110156103ab57600080fd5b810190808035906020019092919050505061179a565b60405180806020018773ffffffffffffffffffffffffffffffffffffffff1681526020018681526020018560038111156103f757fe5b815260200180602001848152602001838103835289818151815260200191508051906020019080838360005b8381101561043e578082015181840152602081019050610423565b50505050905090810190601f16801561046b5780820380516001836020036101000a031916815260200191505b50838103825285818151815260200191508051906020019080838360005b838110156104a4578082015181840152602081019050610489565b50505050905090810190601f1680156104d15780820380516001836020036101000a031916815260200191505b509850505050505050505060405180910390f35b6104ed611933565b6040518082815260200191505060405180910390f35b61050b611939565b604051808273ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146105fa576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260188152602001807f43616c6c6572206973206e6f7420746865206f7261636c65000000000000000081525060200191505060405180910390fd5b6000831415610671576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260188152602001807f43616c6c4964206973207265717569726564206669656c64000000000000000081525060200191505060405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff166005600085815260200190815260200160002060010160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16141561074a576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252600e8152602001807f496e76616c69642063616c6c496400000000000000000000000000000000000081525060200191505060405180910390fd5b6001600381111561075757fe5b82600381111561076357fe5b148061078557506002600381111561077757fe5b82600381111561078357fe5b145b806107a5575060038081111561079757fe5b8260038111156107a357fe5b145b610817576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252600f8152602001807f496e76616c6964207374617475732e000000000000000000000000000000000081525060200191505060405180910390fd5b6002600381111561082457fe5b6005600085815260200190815260200160002060030160009054906101000a900460ff16600381111561085357fe5b1415801561089a575060038081111561086857fe5b6005600085815260200190815260200160002060030160009054906101000a900460ff16600381111561089757fe5b14155b6108ef576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401808060200182810382526026815260200180611b3a6026913960400191505060405180910390fd5b816005600085815260200190815260200160002060030160006101000a81548160ff0219169083600381111561092157fe5b02179055506002600381111561093357fe5b82600381111561093f57fe5b1415610a80578060056000858152602001908152602001600020600401908051906020019061096f929190611a2a565b507f0d8e0e412ba77af0d3f60595ea1c9b1770c9edbb7e0c75b7e0a124a54841ef9c6005600085815260200190815260200160002060010160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16848484604051808573ffffffffffffffffffffffffffffffffffffffff1681526020018481526020018360038111156109fd57fe5b815260200180602001828103825283818151815260200191508051906020019080838360005b83811015610a3e578082015181840152602081019050610a23565b50505050905090810190601f168015610a6b5780820380516001836020036101000a031916815260200191505b509550505050505060405180910390a1610c4e565b600380811115610a8c57fe5b826003811115610a9857fe5b1415610bae577f0d8e0e412ba77af0d3f60595ea1c9b1770c9edbb7e0c75b7e0a124a54841ef9c6005600085815260200190815260200160002060010160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16848484604051808573ffffffffffffffffffffffffffffffffffffffff168152602001848152602001836003811115610b2b57fe5b815260200180602001828103825283818151815260200191508051906020019080838360005b83811015610b6c578082015181840152602081019050610b51565b50505050905090810190601f168015610b995780820380516001836020036101000a031916815260200191505b509550505050505060405180910390a1610c4d565b7f718158e6d05d422dc8312e7da4ec09c046c2f678a8049af1ea43283030fa3bbc6005600085815260200190815260200160002060010160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff168484604051808473ffffffffffffffffffffffffffffffffffffffff168152602001838152602001826003811115610c3a57fe5b8152602001935050505060405180910390a15b5b505050565b600360009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610d16576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260178152602001807f43616c6c6572206973206e6f7420746865206f776e657200000000000000000081525060200191505060405180910390fd5b60008111610d8c576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601c8152602001807f416d6f756e7420706172616d657465722069732072657175697265640000000081525060200191505060405180910390fd5b8060008054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff166370a08231306040518263ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808273ffffffffffffffffffffffffffffffffffffffff16815260200191505060206040518083038186803b158015610e3057600080fd5b505afa158015610e44573d6000803e3d6000fd5b505050506040513d6020811015610e5a57600080fd5b81019080805190602001909291905050501015610ec2576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401808060200182810382526027815260200180611b136027913960400191505060405180910390fd5b60008054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33836040518363ffffffff167c0100000000000000000000000000000000000000000000000000000000028152600401808373ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610f6f57600080fd5b505af1158015610f83573d6000803e3d6000fd5b505050506040513d6020811015610f9957600080fd5b8101908080519060200190929190505050507f4ce7033d118120e254016dccf195288400b28fc8936425acd5f17ce2df3ab7083382604051808373ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060405180910390a150565b600360009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146110c6576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260178152602001807f43616c6c6572206973206e6f7420746865206f776e657200000000000000000081525060200191505060405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415611169576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601e8152602001807f4e6577206f7261636c652061646472657373206973207265717569726564000081525060200191505060405180910390fd5b6000600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905081600260006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055507fed11ba1d5f143e544b1f924e8135aa5c1d2a8cf0dece25726e7e480f356ba4978183604051808373ffffffffffffffffffffffffffffffffffffffff1681526020018273ffffffffffffffffffffffffffffffffffffffff1681526020019250505060405180910390a15050565b600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600360009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614611350576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260198152602001807f53656e646572206d7573742062652053454e4920746f6b656e0000000000000081525060200191505060405180910390fd5b60015483146113c7576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260148152602001807f57726f6e6720616d6f756e74206f662053454e4900000000000000000000000081525060200191505060405180910390fd5b6113cf611aaa565b6113d88361195d565b9050637fffffff8160200151511161143b576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401808060200182810382526031815260200180611ae26031913960400191505060405180910390fd5b6004600081548092919060010191905055508060200151600560006004548152602001908152602001600020600001908051906020019061147d929190611a2a565b508060000151600560006004548152602001908152602001600020600501819055508460056000600454815260200190815260200160002060010160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055508360056000600454815260200190815260200160002060020181905550600060056000600454815260200190815260200160002060030160006101000a81548160ff0219169083600381111561154857fe5b02179055506004548573ffffffffffffffffffffffffffffffffffffffff167f42862d9cab97a7dd805dd8896e0cc926477ee6428efdf319e6fca1d8388ee74a856040518080602001828103825283818151815260200191508051906020019080838360005b838110156115c95780820151818401526020810190506115ae565b50505050905090810190601f1680156115f65780820380516001836020036101000a031916815260200191505b509250505060405180910390a360019150509392505050565b600360009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146116d2576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260178152602001807f43616c6c6572206973206e6f7420746865206f776e657200000000000000000081525060200191505060405180910390fd5b6000811415611749576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260158152602001807f43616c6c56616c7565206973207265717569726564000000000000000000000081525060200191505060405180910390fd5b6000819050816001819055507f2f71a914c996fd8f7fc6b85ed731850edc1107d0656cf5378d1044cbce790cd681600154604051808381526020018281526020019250505060405180910390a15050565b6005602052806000526040600020600091509050806000018054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156118465780601f1061181b57610100808354040283529160200191611846565b820191906000526020600020905b81548152906001019060200180831161182957829003601f168201915b5050505050908060010160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16908060020154908060030160009054906101000a900460ff1690806004018054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156119235780601f106118f857610100808354040283529160200191611923565b820191906000526020600020905b81548152906001019060200180831161190657829003601f168201915b5050505050908060050154905086565b60015481565b60008054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b611965611aaa565b60005b6004811015611a1b57600083828151811061197f57fe5b60200101517f010000000000000000000000000000000000000000000000000000000000000090047f0100000000000000000000000000000000000000000000000000000000000000027f0100000000000000000000000000000000000000000000000000000000000000900460ff16905081600802819060020a02905080836000018181511891508181525050508080600101915050611968565b50818160200181905250919050565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f10611a6b57805160ff1916838001178555611a99565b82800160010185558215611a99579182015b82811115611a98578251825591602001919060010190611a7d565b5b509050611aa69190611ac4565b5090565b604051806040016040528060008152602001606081525090565b5b80821115611add576000816000905550600101611ac5565b509056fe4c656e677468206f6620496e7075745374727563742e646174612063616e6e6f7420657869737420323536206279746573464f534320636f6e7472616320646f206e6f74206861766520656e6f7567682062616c616e63655374617475732069732066696e616c20616e642063616e6e6f74206265206368616e6765642ea2646970667358221220058e602b002f6c8a76333c913190ed772d5a9d20970d91a8b4f61da5241e114c64736f6c634300060c003343616c6c2076616c7565206d7573742062652067726561746572207468616e2030";

        public WhiteListDeployment(): base(BYTECODE)
        {
        }
        public WhiteListDeployment(string byteCode):base(byteCode)
        {
        }

        [Parameter("address", "_owner", 1)]
        public virtual string Owner { get; set; }
    }
}
