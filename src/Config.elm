module Config exposing (..)

import BigInt exposing (BigInt)
import Eth.Types exposing (Address)
import Eth.Utils
import Time
import TokenValue exposing (TokenValue)


mainnetHttpProviderUrl : String
mainnetHttpProviderUrl =
    "https://mainnet.infura.io/v3/e3eef0e2435349bf9164e6f465bd7cf9"


kovanHttpProviderUrl : String
kovanHttpProviderUrl =
    "https://kovan.infura.io/v3/e3eef0e2435349bf9164e6f465bd7cf9"


daiContractAddress : Bool -> Address
daiContractAddress testMode =
    if testMode then
        Eth.Utils.unsafeToAddress "0x4F96Fe3b7A6Cf9725f59d353F723c1bDb64CA6Aa"

    else
        Eth.Utils.unsafeToAddress "0x6B175474E89094C44Da98b954EedeAC495271d0F"


fryAddress : Bool -> Address
fryAddress testMode =
    if testMode then
        Eth.Utils.unsafeToAddress "0x4F1bee416CEcB7Bc3d4A0b94F78e401fb664F4eF"

    else
        Debug.todo "no address for non-testmode FRY"


bucketSaleAddress : Bool -> Address
bucketSaleAddress testMode =
    if testMode then
        Eth.Utils.unsafeToAddress "0xc5CDB6fF1a357E24f530aa2E2c78564b824787F1"

    else
        Debug.todo "No address for non-testMode bucketSale"


bucketSaleScriptsAddress : Bool -> Address
bucketSaleScriptsAddress testMode =
    if testMode then
        Eth.Utils.unsafeToAddress "0x9439E2755CaA6C97CD1AAE82FA97Ce91c93d9137"

    else
        Debug.todo ""


bucketSaleBucketInterval : Bool -> Time.Posix
bucketSaleBucketInterval testMode =
    if testMode then
        Time.millisToPosix <| 1000 * 60 * 10

    else
        Debug.todo "blocks per bucket in non-test-mode"


bucketSaleTokensPerBucket : Bool -> TokenValue
bucketSaleTokensPerBucket testMode =
    if testMode then
        TokenValue.tokenValue <|
            BigInt.fromInt 150

    else
        Debug.todo "tokens per bucket in non-test mode"


bucketSaleNumBuckets : Int
bucketSaleNumBuckets =
    1200