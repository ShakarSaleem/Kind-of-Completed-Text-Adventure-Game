module Helper

open Error

// this is quite halpful.
let ($) x f =
    bind f x