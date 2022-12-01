# CMakeList.txt : Top-level CMake project file, do global configuration
# and include sub-projects here.
#
cmake_minimum_required (VERSION 3.8)

project ("DayOne")

# Include sub-projects.
add_subdirectory ("DayOnePartOne")
configure_file("DayOnePartOne/input.txt" "DayOnePartOne/input.txt" COPYONLY)

add_subdirectory ("DayOnePartTwo")
configure_file("DayOnePartTwo/input.txt" "DayOnePartTwo/input.txt" COPYONLY)