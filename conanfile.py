# Copyright SunnyCase.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# pylint: disable=invalid-name, unused-argument, import-outside-toplevel

from conan import ConanFile
from conan.tools.build import check_min_cppstd
from conan.tools.cmake import CMake, CMakeDeps, CMakeToolchain, cmake_layout


class SCIPSharpConan(ConanFile):
    name = "scipsharp"
    url = "https://github.com/sunnycase/SCIPSharp"
    settings = "os", "compiler", "build_type", "arch"
    options = {
        "shared": [True, False],
        "fPIC": [True, False]
    }
    default_options = {
        "shared": False,
        "fPIC": True
    }

    def requirements(self):
        self.requires("scip/9.2.0")

    def build_requirements(self):
        pass

    def layout(self):
        cmake_layout(self)

    def generate(self):
        tc = CMakeToolchain(self, generator="Ninja")
        tc.generate()
        deps = CMakeDeps(self)
        deps.generate()

    def configure(self):
        min_cppstd = "20"
        check_min_cppstd(self, min_cppstd)

        self.options["scip"].with_gmp = False
        self.options["scip"].with_tpi = False
        self.options["scip"].shared = True

    def cmake_configure(self):
        cmake = CMake(self)
        cmake.configure()
        return cmake

    def build(self):
        cmake = self.cmake_configure()
        cmake.build()

    def package(self):
        cmake = CMake(self)
        cmake.install()
