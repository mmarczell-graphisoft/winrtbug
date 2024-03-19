#pragma once
#include "Foo.g.h"

namespace winrt::winrtcomponent_cpp::implementation
{
    struct Foo : FooT<Foo>
    {
        hstring label();
    };
}

namespace winrt::winrtcomponent_cpp::factory_implementation
{
    struct Foo : FooT<Foo, implementation::Foo>
    {
    };
}