#include "pch.h"
#include "NodeManager.h"
#include "Foo.g.cpp"
#include "CppLib.hpp"

#include <functional>
#include <algorithm>


namespace winrt::winrtcomponent_cpp::implementation
{
    hstring Foo::label()
    {
        return winrt::to_hstring("Hello world!");
    }
}