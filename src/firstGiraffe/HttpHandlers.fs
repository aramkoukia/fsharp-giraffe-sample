namespace firstGiraffe

module HttpHandlers =

    open Microsoft.AspNetCore.Http
    open Giraffe
    open firstGiraffe.Models

    let handleGetHello =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                let response = {
                    Text = "Hello world, from Giraffe!"
                }
                return! json response next ctx
            }