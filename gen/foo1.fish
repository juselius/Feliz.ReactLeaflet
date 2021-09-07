for i in (cat foo)
    string split ',' $i | string join ' ' | read a b
    # echo "    static member inline $b (properties: I"$a"Prop list) ="
    # echo "       Interop.reactApi.createElement (import \"$a\" \"react-leaflet\", createObj !!properties)"
    echo "    let inline mk"$a"Prop (key: string) (value: obj) : I"$a"Prop = unbox (key, value)"
end
