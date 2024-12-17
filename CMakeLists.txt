cmake_minimum_required(VERSION 3.18)

project(SCIPSharp)

find_package(scip REQUIRED)

add_executable(scipsharp test/sciptest.cpp)
target_link_libraries(scipsharp PRIVATE scip::scip)

install(TARGETS scipsharp
        EXPORT ${PROJECT_NAME}Targets
        RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
        LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR}
        ARCHIVE DESTINATION ${CMAKE_INSTALL_LIBDIR}
        )
