# CMakeList.txt : CMake project for DayOne, include source and define
# project specific logic here.
#

# Add source to this project's executable.
add_executable (DayOnePartTwo "DayOnePartTwo.cpp" "DayOnePartTwo.h")

if (CMAKE_VERSION VERSION_GREATER 3.12)
  set_property(TARGET DayOne PROPERTY CXX_STANDARD 20)
endif()
