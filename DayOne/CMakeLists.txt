# CMakeList.txt : Top-level CMake project file, do global configuration
# and include sub-projects here.
#
cmake_minimum_required (VERSION 3.8)

project ("DayOne")

# Include sub-projects.
add_subdirectory ("DayOne")
configure_file("DayOne/input.txt" "DayOne/input.txt" COPYONLY)