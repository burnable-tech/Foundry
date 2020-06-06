module Contracts.BucketSale.Generated.BucketSaleScripts exposing
    ( exitMany
    , getExitInfo
    )

import Abi.Decode as AbiDecode exposing (abiDecode, andMap, data, toElmDecoder, topic)
import Abi.Encode as AbiEncode exposing (Encoding(..), abiEncode)
import BigInt exposing (BigInt)
import Eth.Types exposing (..)
import Eth.Utils as U
import Json.Decode as Decode exposing (Decoder, succeed)
import Json.Decode.Pipeline exposing (custom)



{-

   This file was generated by https://github.com/cmditch/elm-ethereum-generator

-}


{-| "exitMany(address,address,uint256[])" function
-}
exitMany : Address -> Address -> Address -> List BigInt -> Call ()
exitMany contractAddress bucketSale buyer bucketIds =
    { to = Just contractAddress
    , from = Nothing
    , gas = Nothing
    , gasPrice = Nothing
    , value = Nothing
    , data =
        Just <|
            AbiEncode.functionCall "exitMany(address,address,uint256[])"
                [ AbiEncode.address bucketSale
                , AbiEncode.address buyer
                , AbiEncode.list (List.map AbiEncode.uint bucketIds)
                ]
    , nonce = Nothing
    , decoder = Decode.succeed ()
    }


{-| "getExitInfo(address,address)" function
-}
getExitInfo : Address -> Address -> Address -> Call (List BigInt)
getExitInfo contractAddress bucketSale buyer =
    { to = Just contractAddress
    , from = Nothing
    , gas = Nothing
    , gasPrice = Nothing
    , value = Nothing
    , data = Just <| AbiEncode.functionCall "getExitInfo(address,address)" [ AbiEncode.address bucketSale, AbiEncode.address buyer ]
    , nonce = Nothing
    , decoder = toElmDecoder (AbiDecode.staticArray 1201 AbiDecode.uint)
    }