open System
open Newtonsoft.Json
type X ={ Y:decimal }

[<EntryPoint>]
let main argv =
    let original = Some {Y = 79228162477370849463M}
    let serialized = JsonConvert.SerializeObject(original)
    let deserialized = JsonConvert.DeserializeObject<X option>(serialized)
    printfn "%A" serialized
    printfn "%A" deserialized
    printfn "%A"  (deserialized = original)
    0 
