"use client";

import axios from "axios";

export const BASE_URL= "https://localhost:7136/";

export const api = axios.create({
  baseURL: BASE_URL,
});